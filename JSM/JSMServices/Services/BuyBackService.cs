using AutoMapper;
using DataLayer.Entities;
using JSMRepositories;
using JSMServices.IServices;
using JSMServices.ViewModels.BuyBackViewModel;

namespace JSMServices.Services;

public class BuyBackService : IBuyBackService
{
    private readonly BuybackRepository _buybackRepository;
    private readonly OrderRepository _orderRepository;
    private readonly IMapper _mapper;

    public BuyBackService(BuybackRepository buybackRepository, OrderRepository orderRepository, IMapper mapper)
    {
        _orderRepository = orderRepository;
        _buybackRepository = buybackRepository;
        _mapper = mapper;
    }
    public Task PrintInvoice()
    {
        throw new NotImplementedException();
    }
}