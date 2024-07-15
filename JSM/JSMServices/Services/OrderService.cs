using AutoMapper;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.ViewModels.APIResponseViewModel;
using JSMServices.ViewModels.BuyBackViewModel;
using JSMServices.ViewModels.CounterViewMode;
using JSMServices.ViewModels.CustomerViewModel;
using JSMServices.ViewModels.EmployeeViewModel;
using JSMServices.ViewModels.OrderDetailViewModel;
using JSMServices.ViewModels.OrderViewModel;
using System.Security.Claims;

namespace JSMServices.Services;

public class OrderService : IOrderService
{
    private readonly OrderRepository _orderRepository;
    private readonly OrderDetailRepository _orderDetailRepository;
    private readonly BuybackRepository _buybackRepository;
    private readonly EmployeeRepository _employeeRepository;
    private readonly CustomerRepository _customerRepository;
    private readonly CounterRepository _counterRepository;
    private readonly IMapper _mapper;

    public OrderService(OrderRepository orderRepository, IMapper mapper,
        BuybackRepository buybackRepository, OrderDetailRepository orderDetailRepository
        , CounterRepository counterRepository, EmployeeRepository employeeRepository,
        CustomerRepository customerRepository)
    {
        _counterRepository = counterRepository;
        _customerRepository = customerRepository;
        _employeeRepository = employeeRepository;
        _orderRepository = orderRepository;
        _mapper = mapper;
        _buybackRepository = buybackRepository;
        _orderDetailRepository = orderDetailRepository;
    }

    public async Task<ApiResponse> CreateNewOrderSelling(CreateNewSellingViewModel viewmodel, ClaimsPrincipal claims)
    {
        try
        {
            var order = new Order();
            var orderDetail = new OrderDetail();

            var getOrder = await _orderRepository.GetAllWithAsync();
            order = getOrder.FirstOrDefault(c => c.OrderId.ToLower() == viewmodel.OrderId.ToLower());
            if (order != null)
            {
                return new ApiResponse { IsSuccess = true, Data = new List<object> { order } };
            }
            else
            {
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
                    var checkPromotionCodeExisted = _orderRepository.GetSingleWithAsync(c => c.PromotionCode.ToLower().Equals(viewmodel.PromotionCode.ToLower()));
                    if (checkPromotionCodeExisted == null)
                    {
                        return new ApiResponse { IsSuccess = false, Message = "PromotionCode does not exist" };
                    }
                }

                if (viewmodel.CPId != Guid.Empty && viewmodel.CPId != null)
                {
                    var checkCustomerPolicyIdExisted = _orderRepository.GetSingleWithAsync(e => e.CPId.Equals(viewmodel.CPId));
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

                foreach (var detailViewModel in viewmodel.OrderDetail)
                {
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
                }
            }
            return new ApiResponse { IsSuccess = true, Data = new List<object> { order } };
        }
        catch (Exception ex)
        {
            return new ApiResponse { IsSuccess = false, Message = ex.InnerException?.Message ?? ex.Message };
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
                    OrderDate = DateTime.Now,
                    Type = Order.Types.BuyBack,
                    CounterId = viewModel.CounterId,
                    OrderStatus = Order.OrderStatuses.Created,
                    PaymentId = 1,
                    AccumulatedPoint = 0,
                    PromotionCode = "",
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
                            Name = od.Name
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

    public async Task<ICollection<Order>> GetOrderByCustomerId(Guid customerId)
    {
        try
        {
            var listOrder = await _orderRepository.GetAllWithAsync();
            var filterOrder = listOrder
                .Where(o => o.CustomerId == customerId)
                .ToList();
            if (!filterOrder.Any())
            {
                throw new Exception("No orders found for the specified CustomerId.");
            }

            return filterOrder;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}