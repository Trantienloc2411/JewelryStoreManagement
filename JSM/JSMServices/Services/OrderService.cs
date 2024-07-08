using System.Security.Claims;
using AutoMapper;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.ViewModels.BuyBackViewModel;
using JSMServices.ViewModels.OrderViewModel;
using Microsoft.EntityFrameworkCore;

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

    public async Task<Order> CreateNewOrder(CreateOrderViewModel createOrderViewModel)
    {
        try
        {
            var existedOrderList = _orderRepository.GetAll();
            var order = new Order();
            if (existedOrderList.FirstOrDefault(e => e.CustomerId.Equals(createOrderViewModel.CustomerId)) != null)
            {
                throw new Exception($"CustomerId '{createOrderViewModel.CustomerId}' is already existed. Please use another Id.");
            }
            if (existedOrderList.FirstOrDefault(e => e.EmployeeId.Equals(createOrderViewModel.EmployeeId)) != null)
            {
                throw new Exception($"EmployeeId '{createOrderViewModel.EmployeeId}' is already existed. Please use another Id.");
            }
            if (existedOrderList.FirstOrDefault(e => e.PromotionCode.Equals(createOrderViewModel.PromotionCode)) != null)
            {
                throw new Exception($"PromotionCode '{createOrderViewModel.PromotionCode}' is already existed. Please use another PromotionCode.");
            }
            _mapper.Map(createOrderViewModel, order);
            order.OrderId = GenerateRandomString(8);
            var entityEntry = await _orderRepository.AddSingleWithAsync(order);

            if (entityEntry.State == EntityState.Added)
            {
                await _orderRepository.SaveChangesAsync();
                return order;
            }
        }
        catch (Exception ex)
        {
            // Log the exception or handle it in some other way
            throw new Exception($"An error occurred while adding the Order: {ex.Message}");
        }

        // If we reach this point, something went wrong during the add operation
        throw new Exception("An error occurred while adding the Order.");
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