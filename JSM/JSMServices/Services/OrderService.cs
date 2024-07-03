using AutoMapper;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.ViewModels.OrderViewModel;
using Microsoft.EntityFrameworkCore;

namespace JSMServices.Services;

public class OrderService : IOrderService
{
    private readonly OrderRepository _orderRepository;
    private readonly IMapper _mapper;

    public OrderService(OrderRepository orderRepository, IMapper mapper)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
    }

    public async Task<ICollection<Order>> GetAllOrders()
    {
        try
        {
            var listOrder = await _orderRepository.GetAllWithAsync();
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

}