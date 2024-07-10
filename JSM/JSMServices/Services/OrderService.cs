using AutoMapper;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.ViewModels.BuyBackViewModel;
using JSMServices.ViewModels.OrderViewModel;
using System.Security.Claims;

namespace JSMServices.Services;

public class OrderService : IOrderService
{
    private readonly OrderRepository _orderRepository;
    private readonly OrderDetailRepository _orderDetailRepository;
    private readonly BuybackRepository _buybackRepository;
    private readonly IMapper _mapper;

    public OrderService(OrderRepository orderRepository, IMapper mapper,
        BuybackRepository buybackRepository, OrderDetailRepository orderDetailRepository)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
        _buybackRepository = buybackRepository;
        _orderDetailRepository = orderDetailRepository;
    }

    public async Task<ICollection<Order>> GetAllOrders()
    {
        try
        {
            var listOrder = _orderRepository.GetAll();
            return listOrder;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception(e.Message);
        }
    }

    public async Task<Order> CreateNewOrderSelling(CreateNewSellingViewModel viewmodel, ClaimsPrincipal claims)
    {
        try
        {
            var order = new Order();
            var orderDetail = new OrderDetail();

            var getOrder = await _orderRepository.GetAllWithAsync();
            order = getOrder.FirstOrDefault(c => c.OrderId.ToLower() == viewmodel.OrderId.ToLower());
            if (order != null)
            {
                return order;
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
                    PromotionCode = "string",
                    AccumulatedPoint = viewmodel.AccumulatedPoint,
                    CounterId = viewmodel.CounterId,
                    PaymentId = viewmodel.PaymentId,
                    OrderStatus = Order.OrderStatuses.Created,
                };
                _orderRepository.Add(order);
                await _orderRepository.SaveChangesAsync();

                orderDetail = new OrderDetail
                {
                    OrderDetailId = GenerateRandomString(8),
                    ProductId = viewmodel.OrderDetail.ProductId,
                    OrderId = viewmodel.OrderId,
                    Quantity = viewmodel.OrderDetail.Quantity,
                    UnitPrice = viewmodel.OrderDetail.UnitPrice,
                    ManufactureCost = viewmodel.OrderDetail.ManufactureCost
                };
                _orderDetailRepository.Add(orderDetail);
                await _buybackRepository.SaveChangesAsync();
            }
            return order;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.InnerException?.Message ?? ex.Message);
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
                    PromotionCode = "string",
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
}