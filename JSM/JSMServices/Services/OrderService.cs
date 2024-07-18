using AutoMapper;
using DataLayer.Entities;
using JewelryStoreManagement;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.BuyBackViewModel;
using JSMServices.ViewModels.CounterViewMode;
using JSMServices.ViewModels.CustomerViewModel;
using JSMServices.ViewModels.EmployeeViewModel;
using JSMServices.ViewModels.OrderDetailViewModel;
using JSMServices.ViewModels.OrderViewModel;
using JSMServices.ViewModels.ProductViewModel;
using JSMServices.ViewModels.TypePriceViewModel;
using System.Security.Claims;
using System.Transactions;

namespace JSMServices.Services;

public class OrderService : IOrderService
{
    private readonly OrderRepository _orderRepository;
    private readonly OrderDetailRepository _orderDetailRepository;
    private readonly BuybackRepository _buybackRepository;
    private readonly EmployeeRepository _employeeRepository;
    private readonly CustomerRepository _customerRepository;
    private readonly CounterRepository _counterRepository;
    private readonly ProductRepository _productRepository;
    private readonly TypePriceRepository _typePriceRepository;
    private readonly PromotionRepository _promotionRepository;
    private readonly CustomerPolicyRepository _customerPolicyRepository;
    private readonly IMapper _mapper;
    private readonly WarrantyRepository _warrantyRepository;

    public OrderService(OrderRepository orderRepository, IMapper mapper,
        BuybackRepository buybackRepository, OrderDetailRepository orderDetailRepository
        , CounterRepository counterRepository, EmployeeRepository employeeRepository,
        CustomerRepository customerRepository, ProductRepository productRepository,
        TypePriceRepository typePriceRepository, PromotionRepository promotionRepository, CustomerPolicyRepository customerPolicyRepository, IOrderDetailService orderDetailService, WarrantyRepository warrantyRepository)
    {
        _typePriceRepository = typePriceRepository;
        _counterRepository = counterRepository;
        _customerRepository = customerRepository;
        _employeeRepository = employeeRepository;
        _orderRepository = orderRepository;
        _mapper = mapper;
        _buybackRepository = buybackRepository;
        _orderDetailRepository = orderDetailRepository;
        _productRepository = productRepository;
        _promotionRepository = promotionRepository;
        _customerPolicyRepository = customerPolicyRepository;
        _warrantyRepository = warrantyRepository;
    }

    public async Task<ApiResponse> CreateNewOrderSelling(CreateNewSellingViewModel viewmodel, ClaimsPrincipal claims)
    {
        using (var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
        {
            try
            {
                var order = new Order();
                var orderDetail = new OrderDetail();

                var getOrder = await _orderRepository.GetAllWithAsync();
                var getPromotionCode = await _promotionRepository.GetAllWithAsync();
                order = getOrder.FirstOrDefault(c => c.OrderId.ToLower() == viewmodel.OrderId.ToLower());
                if (order != null)
                {
                    return new ApiResponse { IsSuccess = true, Data = new List<object> { order } };
                }
                else
                {
                    var customerPoint = await _customerRepository.GetSingleWithAsync(p => p.CustomerId == viewmodel.CustomerId);
                    if (customerPoint == null)
                    {
                        return new ApiResponse { IsSuccess = false, Message = "Customer does not exist" };
                    }
                    order = new Order
                    {
                        OrderId = viewmodel.OrderId,
                        CustomerId = viewmodel.CustomerId,
                        EmployeeId = Guid.Parse(claims.FindFirst("EmployeeId").Value),
                        OrderDate = DateTime.Now,
                        Discount = viewmodel.Discount,
                        Type = Order.Types.Selling,
                        PromotionCode = viewmodel.PromotionCode,
                        CPId = viewmodel.CPId,
                        AccumulatedPoint = viewmodel.AccumulatedPoint,
                        CounterId = viewmodel.CounterId,
                        PaymentId = viewmodel.PaymentId,
                        OrderStatus = Order.OrderStatuses.Created,
                    };
                    if (!string.IsNullOrEmpty(viewmodel.PromotionCode))
                    {
                        var checkPromotionCodeExisted = await _promotionRepository.GetSingleWithAsync(c => c.PromotionCode.ToLower().Equals(viewmodel.PromotionCode.ToLower()));
                        if (checkPromotionCodeExisted == null)
                        {
                            return new ApiResponse { IsSuccess = false, Message = "PromotionCode does not exist" };
                        }
                    }

                    if (viewmodel.CPId != Guid.Empty && viewmodel.CPId != null)
                    {
                        var checkCustomerPolicyIdExisted = await _customerPolicyRepository.GetSingleWithAsync(e => e.CPId.Equals(viewmodel.CPId));
                        if (checkCustomerPolicyIdExisted == null)
                        {
                            return new ApiResponse { IsSuccess = false, Message = "CustomerPolicyId does not exist" };
                        }
                        var existingCPIdOrder = getOrder.FirstOrDefault(c => c.CPId == viewmodel.CPId);
                        if (existingCPIdOrder != null)
                        {
                            return new ApiResponse { IsSuccess = false, Message = "An order with this CPId already exists." };
                        }
                    }

                    _orderRepository.Add(order);
                    await _orderRepository.SaveChangesAsync();

                    customerPoint.AccumulatedPoint += viewmodel.AccumulatedPoint;
                    _customerRepository.Update(customerPoint);
                    await _customerRepository.SaveChangesAsync();

                    foreach (var detailViewModel in viewmodel.OrderDetail)
                    {
                        var product = await _productRepository.GetSingleWithAsync(p => p.ProductId == detailViewModel.ProductId);
                        if (product == null)
                        {
                            return new ApiResponse { IsSuccess = false, Message = $"Product with ID {detailViewModel.ProductId} does not exist" };
                        }
                        if (product.Quantity < detailViewModel.Quantity)
                        {
                            return new ApiResponse { IsSuccess = false, Message = $"Not enough stock for product {product.Name}. Available: {product.Quantity}, Requested: {detailViewModel.Quantity}" };
                        }
                        orderDetail = new OrderDetail
                        {
                            OrderDetailId = GenerateRandomString(8),
                            ProductId = detailViewModel.ProductId,
                            OrderId = viewmodel.OrderId,
                            Quantity = detailViewModel.Quantity,
                            UnitPrice = detailViewModel.UnitPrice,
                            ManufactureCost = detailViewModel.ManufactureCost
                        };

                        _orderDetailRepository.Add(orderDetail);
                        await _orderDetailRepository.SaveChangesAsync();

                        product.Quantity -= detailViewModel.Quantity;
                        _productRepository.Update(product);
                        await _productRepository.SaveChangesAsync();
                    }

                }
                transaction.Complete();
                return new ApiResponse { IsSuccess = true, Data = new List<object> { order } };
            }
            catch (Exception ex)
            {
                return new ApiResponse { IsSuccess = false, Message = ex.InnerException?.Message ?? ex.Message };
            }
        }
    }

    public async Task<Order> GetOrderByOrderId(string orderCode)
    {
        try
        {
            var result =
                await _orderRepository.GetSingleWithIncludeAsync(c => c.OrderId == orderCode, c => c.OrderDetails,
                    c => c.Employee);
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


    private static Random _random = new Random();
    private static string GenerateRandomString(int length)
    {
        const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+=[]{}|\\;:,.<>/?";
        var chars = new char[length];
        for (int i = 0; i < length; i++)
        {
            chars[i] = allowedChars[_random.Next(0, allowedChars.Length)];
        }
        return new string(chars);
    }

    public async Task<Order> CreateNewBuyBack(CreateNewBuyBackViewModel viewModel, ClaimsPrincipal claims)
    {
        try
        {
            var order = new Order();
            var buyback = new BuyBack();
            var orderDetail = await
                _orderDetailRepository.GetSingleWithAsync(c =>
                    c.OrderDetailId.ToUpper() == viewModel.OrderDetailID.ToUpper());

            var warrantyList = _warrantyRepository.GetAll();
            var warranty =
                warrantyList.FirstOrDefault(c => c.OrderDetailId.ToUpper() == viewModel.OrderDetailID.ToUpper());
            if (warranty == null)
            {
                warranty = new Warranty();
            }
            var getOrder = await _orderRepository.GetAllWithAsync();
            order = getOrder.FirstOrDefault(c => c.OrderId.ToLower() == viewModel.OrderId.ToLower());
            if (order != null)
            {
                return order;
            }
            else
            {
                order = new Order
                {
                    OrderId = viewModel.OrderId,
                    CustomerId = viewModel.CustomerId,
                    EmployeeId = Guid.Parse(claims.FindFirst("EmployeeId").Value),
                    OrderDate = DateTime.UtcNow,
                    Type = Order.Types.BuyBack,
                    CounterId = viewModel.CounterId,
                    OrderStatus = Order.OrderStatuses.Created,
                    PaymentId = 1,
                    AccumulatedPoint = 0,
                    PromotionCode = null,
                    Discount = 0
                };
                _orderRepository.Add(order);
                await _orderRepository.SaveChangesAsync();

                buyback = new BuyBack
                {
                    BuyBackId = Guid.NewGuid(),
                    ProductId = viewModel.BuyBack.ProductId,
                    OrderId = viewModel.OrderId,
                    Price = viewModel.BuyBack.Price,
                    Quantity = viewModel.BuyBack.Quantity,
                    HaveInvoice = viewModel.BuyBack.HaveInvoice,
                    ManufactureCost = viewModel.BuyBack.ManufactureCost
                };
                _buybackRepository.Add(buyback);
                await _buybackRepository.SaveChangesAsync();


            }

            if (orderDetail.OrderDetailStatus != OrderDetail.OrderDetailStatuses.BuyBack)
            {
                orderDetail.OrderDetailStatus = OrderDetail.OrderDetailStatuses.BuyBack;
                await _orderDetailRepository.UpdateWithAsync(orderDetail);
                _orderDetailRepository.SaveChanges();
            }
            

            if (warranty != null) 
            {
                _warrantyRepository.Remove(warranty);
                _warrantyRepository.SaveChanges();
            }
            

            return order;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.InnerException?.Message ?? ex.Message);
        }
    }

    public async Task<ICollection<OrderOrderDetailByCounterIdViewModel>> GetOrderOrderDetailByCounterId(int counterId)
    {
        try
        {
            var listOrder = await _orderRepository.GetAllWithAsync();
            var filterOrders = listOrder
                .Where(p => p.CounterId.Equals(counterId))
                .ToList();

            if (!filterOrders.Any())
            {
                throw new Exception("No orders found for the specified counterId.");
            }

            var listOrderDetail = _orderDetailRepository.GetAll();

            var ordersWithDetails = new List<OrderOrderDetailByCounterIdViewModel>();

            foreach (var order in filterOrders)
            {
                var orderWithDetails = new OrderOrderDetailByCounterIdViewModel
                {
                    OrderId = order.OrderId,
                    CustomerId = order.CustomerId,
                    EmployeeId = order.EmployeeId,
                    OrderDate = order.OrderDate,
                    Discount = order.Discount ?? 0,
                    Type = order.Type,
                    PromotionCode = order.PromotionCode ?? "",
                    AccumulatedPoint = order.AccumulatedPoint ?? 0,
                    CounterId = order.CounterId,
                    PaymentId = order.PaymentId,
                    OrderStatus = order.OrderStatus,
                    OrderDetail = listOrderDetail
                        .Where(od => od.OrderId == order.OrderId)
                        .Select(od => new OrderOrderDetailViewModel
                        {
                            OrderDetailId = od.OrderDetailId,
                            OrderId = od.OrderId,
                            ProductId = od.ProductId,
                            Quantity = od.Quantity,
                            UnitPrice = od.UnitPrice,
                            ManufactureCost = od.ManufactureCost,
                            OrderDetailStatus = od.OrderDetailStatus
                        })
                        .ToList()
                };

                ordersWithDetails.Add(orderWithDetails);
            }
            return ordersWithDetails;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<ICollection<OrderViewModel>> GetAllOrders()
    {
        try
        {
            var listOrder = await _orderRepository.GetAllWithAsync();
            var employeeName = _employeeRepository.GetAll();
            var customerName = _customerRepository.GetAll();
            var counterName = _counterRepository.GetAll();
            var ordersWithNames = new List<OrderViewModel>();

            foreach (var order in listOrder)
            {
                var orderWithNames = new OrderViewModel
                {
                    OrderId = order.OrderId,
                    CustomerId = order.CustomerId,
                    EmployeeId = order.EmployeeId,
                    OrderDate = order.OrderDate,
                    Discount = order.Discount ?? 0,
                    Type = order.Type,
                    PromotionCode = order.PromotionCode ?? "",
                    AccumulatedPoint = order.AccumulatedPoint ?? 0,
                    CounterId = order.CounterId,
                    PaymentId = order.PaymentId,
                    OrderStatus = order.OrderStatus,
                    Employee = employeeName
                        .Where(en => en.EmployeeId == order.EmployeeId)
                        .Select(od => new EmployeeNameViewModel
                        {
                            Name = od.Name
                        })
                        .First(),
                    Customer = customerName
                        .Where(en => en.CustomerId == order.CustomerId)
                        .Select(od => new CustomerNameViewModel
                        {
                            CustomerId = od.CustomerId,
                            Name = od.Name,
                            Phone = od.Phone,
                            Address = od.Address,
                            Email = od.Email

                        })
                        .First(),
                    Counter = counterName
                        .Where(en => en.CounterId == order.CounterId)
                        .Select(od => new CounterNameViewModel
                        {
                            CounterName = od.CounterName
                        })
                        .First()
                };

                ordersWithNames.Add(orderWithNames);
            }
            return ordersWithNames;

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception(e.Message);
        }
    }
    public async Task<(OrderByOrderIdViewModel, ApiResponse)> GetOrdersByOrderId(string orderId)
    {
        var apiResponse = new ApiResponse();
        try
        {
            var listOrder = await _orderRepository.GetAllWithAsync();
            var filterOrder = listOrder
                .Where(o => o.OrderId == orderId)
                .ToList();
            if (!filterOrder.Any())
            {
                apiResponse.IsSuccess = false;
                apiResponse.Message = "No orders found for the specified OrderId.";
                return (null, apiResponse);
            }

            var order = filterOrder.First();

            var listOrderDetail = _orderDetailRepository.GetAll();
            var listCustomer = _customerRepository.GetAll();
            var listEmplyoee = _employeeRepository.GetAll();
            var listProduct = _productRepository.GetAll();
            var listTypePrice = _typePriceRepository.GetAll();

            var orderWithAllDetail = new OrderByOrderIdViewModel
            {
                OrderId = order.OrderId,
                CustomerId = order.CustomerId,
                EmployeeId = order.EmployeeId,
                OrderDate = order.OrderDate,
                Discount = order.Discount ?? 0,
                Type = order.Type,
                PromotionCode = order.PromotionCode ?? "",
                AccumulatedPoint = order.AccumulatedPoint ?? 0,
                CounterId = order.CounterId,
                PaymentId = order.PaymentId,
                OrderStatus = order.OrderStatus,
                OrderDetail = listOrderDetail
                    .Where(od => od.OrderId == order.OrderId)
                    .Select(od => new OrderDetailsViewModel
                    {
                        OrderDetailId = od.OrderDetailId,
                        OrderId = od.OrderId,
                        ProductId = od.ProductId,
                        Quantity = od.Quantity,
                        UnitPrice = od.UnitPrice,
                        ManufactureCost = od.ManufactureCost,
                        OrderDetailStatus = od.OrderDetailStatus,
                        Products = listProduct
                            .Where(p => p.ProductId == od.ProductId)
                            .Select(p => new ProductByOrderDetailViewModel
                            {
                                ProductId = p.ProductId,
                                Name = p.Name,
                                Barcode = p.Barcode,
                                ManufactureCost = p.ManufactureCost,
                                Weight = p.ManufactureCost,
                                Quantity = p.Quantity,
                                Description = p.Description,
                                CounterId = p.CounterId,
                                TypeId = p.TypeId,
                                Img = p.Img,
                                CertificateUrl = p.CertificateUrl,
                                ProductStatus = p.ProductStatus,
                                Price = p.Price,
                                MarkupRate = p.MarkupRate,
                                WeightUnit = p.WeightUnit,
                                StonePrice = p.StonePrice,
                                TypePrice = listTypePrice
                                    .Where(tp => tp.TypeId == p.TypeId)
                                    .Select(tp => new TypePricesViewModel
                                    {
                                        TypeId = tp.TypeId,
                                        TypeName = tp.TypeName,
                                        BuyPricePerGram = tp.BuyPricePerGram,
                                        SellPricePerGram = tp.SellPricePerGram,
                                        DateUpdated = tp.DateUpdated,
                                    }).First(),
                            }).First(),
                    }).ToList(),
                Customer = listCustomer
                    .Where(en => en.CustomerId == order.CustomerId)
                    .Select(customer => new CustomerByOrderViewModel
                    {
                        CustomerId = customer.CustomerId,
                        Name = customer.Name,
                        Address = customer.Address,
                        Phone = customer.Phone,
                        AccumulatedPoint = customer.AccumulatedPoint,
                        Email = customer.Email,
                        CustomerGender = customer.CustomerGender
                    })
                    .First(),
                Employee = listEmplyoee
                    .Where(e => e.EmployeeId == order.EmployeeId)
                    .Select(e => new EmployeeByOrderViewModel
                    {
                        EmployeeId = e.EmployeeId,
                        Name = e.Name,
                        Email = e.Email,
                        Phone = e.Phone,
                        EmployeeStatus = e.EmployeeStatus,
                        Password = e.Password,
                        EmployeeGender = e.EmployeeGender,
                        IsLogin = e.IsLogin,
                        ManagedBy = e.ManagedBy,
                        CounterId = e.CounterId,
                        RoleId = e.RoleId
                    })
                    .First()
            };

            apiResponse.IsSuccess = true;
            return (orderWithAllDetail, apiResponse);

        }
        catch (Exception e)
        {
            apiResponse.IsSuccess = false;
            apiResponse.Message = e.Message;
            return (null, apiResponse);
        }
    }
    //public async Task<(ICollection<OrderByOrderIdViewModel>, ApiResponse)> GetOrdersByOrderId(string orderId)
    //{
    //    var apiResponse = new ApiResponse();
    //    try
    //    {
    //        var listOrder = await _orderRepository.GetAllWithAsync();
    //        var filterOrder = listOrder
    //            .Where(o => o.OrderId == orderId)
    //            .ToList();
    //        if (!filterOrder.Any())
    //        {
    //            apiResponse.IsSuccess = false;
    //            apiResponse.Message = "No orders found for the specified OrderId.";
    //            return (null, apiResponse);
    //        }
    //        var listOrderDetail = _orderDetailRepository.GetAll();
    //        var listCustomer = _customerRepository.GetAll();
    //        var listEmplyoee = _employeeRepository.GetAll();
    //        var listProduct = _productRepository.GetAll();
    //        var listTypePrice = _typePriceRepository.GetAll();
    //        var ordersWithAllDetails = new List<OrderByOrderIdViewModel>();

    //        foreach (var order in filterOrder)
    //        {
    //            var orderWithAllDetail = new OrderByOrderIdViewModel
    //            {
    //                OrderId = order.OrderId,
    //                CustomerId = order.CustomerId,
    //                EmployeeId = order.EmployeeId,
    //                OrderDate = order.OrderDate,
    //                Discount = order.Discount ?? 0,
    //                Type = order.Type,
    //                PromotionCode = order.PromotionCode ?? "",
    //                AccumulatedPoint = order.AccumulatedPoint ?? 0,
    //                CounterId = order.CounterId,
    //                PaymentId = order.PaymentId,
    //                OrderStatus = order.OrderStatus,
    //                OrderDetail = listOrderDetail
    //                    .Where(od => od.OrderId == order.OrderId)
    //                    .Select(od => new OrderDetailsViewModel
    //                    {
    //                        OrderDetailId = od.OrderDetailId,
    //                        OrderId = od.OrderId,
    //                        ProductId = od.ProductId,
    //                        Quantity = od.Quantity,
    //                        UnitPrice = od.UnitPrice,
    //                        ManufactureCost = od.ManufactureCost,
    //                        OrderDetailStatus = od.OrderDetailStatus,
    //                        Products = listProduct
    //                        .Where(p => p.ProductId == od.ProductId)
    //                        .Select(p => new ProductByOrderDetailViewModel
    //                        {
    //                            ProductId = p.ProductId,
    //                            Name = p.Name,
    //                            Barcode = p.Barcode,
    //                            ManufactureCost = p.ManufactureCost,
    //                            Weight = p.ManufactureCost,
    //                            Quantity = p.Quantity,
    //                            Description = p.Description,
    //                            CounterId = p.CounterId,
    //                            TypeId = p.TypeId,
    //                            Img = p.Img,
    //                            CertificateUrl = p.CertificateUrl,
    //                            ProductStatus = p.ProductStatus,
    //                            Price = p.Price,
    //                            MarkupRate = p.MarkupRate,
    //                            WeightUnit = p.WeightUnit,
    //                            StonePrice = p.StonePrice,
    //                            TypePrice = listTypePrice
    //                            .Where(tp => tp.TypeId == p.TypeId)
    //                            .Select(tp => new TypePricesViewModel
    //                            {
    //                                TypeId = tp.TypeId,
    //                                TypeName = tp.TypeName,
    //                                BuyPricePerGram = tp.BuyPricePerGram,
    //                                SellPricePerGram = tp.SellPricePerGram,
    //                                DateUpdated = tp.DateUpdated,
    //                            }).First(),
    //                        }).First(),
    //                    })
    //                    .ToList(),
    //                Customer = listCustomer
    //                    .Where(en => en.CustomerId == order.CustomerId)
    //                    .Select(customer => new CustomerByOrderViewModel
    //                    {
    //                        CustomerId = customer.CustomerId,
    //                        Name = customer.Name,
    //                        Address = customer.Address,
    //                        Phone = customer.Phone,
    //                        AccumulatedPoint = customer.AccumulatedPoint,
    //                        Email = customer.Email,
    //                        CustomerGender = customer.CustomerGender

    //                    })
    //                    .First(),
    //                Employee = listEmplyoee
    //                    .Where(e => e.EmployeeId == order.EmployeeId)
    //                    .Select(e => new EmployeeByOrderViewModel
    //                    {
    //                        EmployeeId = e.EmployeeId,
    //                        Name = e.Name,
    //                        Email = e.Email,
    //                        Phone = e.Phone,
    //                        EmployeeStatus = e.EmployeeStatus,
    //                        Password = e.Password,
    //                        EmployeeGender = e.EmployeeGender,
    //                        IsLogin = e.IsLogin,
    //                        ManagedBy = e.ManagedBy,
    //                        CounterId = e.CounterId,
    //                        RoleId = e.RoleId

    //                    })
    //                    .First()
    //            };

    //            ordersWithAllDetails.Add(orderWithAllDetail);
    //        }
    //        apiResponse.IsSuccess = true;
    //        return (ordersWithAllDetails, apiResponse);

    //    }
    //    catch (Exception e)
    //    {
    //        apiResponse.IsSuccess = false;
    //        apiResponse.Message = e.Message;
    //        return (null, apiResponse);
    //    }
    //}

    public async Task<ICollection<Order>> GetOrderByEmployeeId(Guid employeeId)
    {
        try
        {
            var listOrder = await _orderRepository.GetAllWithAsync();
            var filterOrder = listOrder
                .Where(o => o.EmployeeId == employeeId)
                .ToList();
            if (!filterOrder.Any())
            {
                throw new Exception("No orders found for the specified EmployeeId.");
            }
            return filterOrder;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<ICollection<OrderByCustomerIdViewModel>> GetOrderByCustomerId(Guid customerId)
    {
        try
        {
            var listOrder = await _orderRepository.GetAllWithAsync();
            var listCustomer = _customerRepository.GetAll();
            var ordersWithCustomer = new List<OrderByCustomerIdViewModel>();
            var filterOrder = listOrder
                .Where(o => o.CustomerId == customerId)
                .ToList();
            if (!filterOrder.Any())
            {
                throw new Exception("No orders found for the specified CustomerId.");
            }

            foreach (var order in filterOrder)
            {
                var orderWithCustomer = new OrderByCustomerIdViewModel
                {
                    OrderId = order.OrderId,
                    CustomerId = order.CustomerId,
                    EmployeeId = order.EmployeeId,
                    OrderDate = order.OrderDate,
                    Discount = order.Discount ?? 0,
                    Type = order.Type,
                    PromotionCode = order.PromotionCode ?? "",
                    AccumulatedPoint = order.AccumulatedPoint ?? 0,
                    CounterId = order.CounterId,
                    PaymentId = order.PaymentId,
                    OrderStatus = order.OrderStatus,
                    Customer = listCustomer
                        .Where(en => en.CustomerId == order.CustomerId)
                        .Select(od => new CustomerNameViewModel
                        {
                            CustomerId = od.CustomerId,
                            Name = od.Name,
                            Phone = od.Phone,
                            Address = od.Address,
                            Email = od.Email

                        })
                        .First(),
                };

                ordersWithCustomer.Add(orderWithCustomer);
            }
            return ordersWithCustomer;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    public async Task<ApiResponse> UpdateOrderStatus(UpdateOrderStatusViewModel updateOrderStatusViewModel, string orderId)
    {
        try
        {
            var order = await _orderRepository.GetAllWithAsync();
            var filterOrder = order.FirstOrDefault(c => c.OrderId == orderId);
            if (filterOrder == null)
            {
                return new ApiResponse
                {
                    IsSuccess = false,
                    Data = null,
                    Message = $"Update not successfully! Reload Page again!"
                };

            }
            else
            {
                var customerPolicyUpdate = _mapper.Map(updateOrderStatusViewModel, filterOrder);
                await _orderRepository.UpdateWithAsync(customerPolicyUpdate);
                return new ApiResponse
                {
                    IsSuccess = true,
                    Data = null,
                    Message = $"Update Successfully"
                };
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    public async Task<ApiResponse> UndoPointQuantity(string orderId)
    {
        try
        {
            var getOrder = await _orderRepository.GetAllWithAsync();
            var filterOrder = getOrder.FirstOrDefault(c => c.OrderId.ToLower() == orderId.ToLower());
            if (filterOrder == null)
            {
                return new ApiResponse
                {
                    IsSuccess = false,
                    Data = null,
                    Message = "Update not successfully! Reload Page again!"
                };
            }
            else
            {
                if (filterOrder.OrderStatus != Order.OrderStatuses.Cancelled)
                {
                    return new ApiResponse
                    {
                        IsSuccess = false,
                        Data = null,
                        Message = "Update failed! Order is not cancelled."
                    };
                }

                var customerPoint = await _customerRepository.GetSingleWithAsync(p => p.CustomerId == filterOrder.CustomerId);
                if (customerPoint == null)
                {
                    return new ApiResponse { IsSuccess = false, Message = "Customer does not exist" };
                }
                int accumulatedPoint = filterOrder.AccumulatedPoint ?? 0;
                customerPoint.AccumulatedPoint -= accumulatedPoint;
                _customerRepository.Update(customerPoint);
                await _customerRepository.SaveChangesAsync();

                var orderDetails = (await _orderDetailRepository.GetAllWithAsync()).Where(d => d.OrderId == filterOrder.OrderId).ToList();
                var filterOrderDetail = orderDetails.FirstOrDefault(d => d.OrderId == filterOrder.OrderId);

                foreach (var orderDetail in orderDetails)
                {
                    var product = await _productRepository.GetSingleWithAsync(p => p.ProductId == orderDetail.ProductId);
                    if (product == null)
                    {
                        return new ApiResponse { IsSuccess = false, Message = "Product does not exist" };
                    }

                    product.Quantity += orderDetail.Quantity;
                    _productRepository.Update(product);
                }
                await _productRepository.SaveChangesAsync();


                return new ApiResponse
                {
                    IsSuccess = true,
                    Data = null,
                    Message = "Update Successfully"
                };
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


    public async Task<Order> GetBuyBackByOrderId(string orderId)
    {

        try
        {
            var order = await _orderRepository.GetSingleWithIncludeAsync(e => e.OrderId.ToUpper() == orderId.ToUpper(),
                e => e.BuyBack, e => e.Customer, e => e.Employee);
            return order;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}