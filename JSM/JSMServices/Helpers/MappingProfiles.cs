using AutoMapper;
using DataLayer.Entities;
using JewelryStoreManagement.ViewModels;
using JSMServices.ViewModels.CustomerPolicyViewModel;
using JSMServices.ViewModels.CustomerViewModel;
using JSMServices.ViewModels.OrderViewModel;
using JSMServices.ViewModels.ProductViewModel;
using JSMServices.ViewModels.PromotionViewModel;
using JSMServices.ViewModels.TypePriceViewModel;

namespace JewelryStoreManagement.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<RegisterEmployeeViewModel, Employee>().ReverseMap();
        CreateMap<LoginEmployeeViewModel, Employee>().ReverseMap();

        CreateMap<ProductViewModel, Product>().ReverseMap();
        CreateMap<AddProductViewModel, Product>().ReverseMap();
        CreateMap<UpdateProductViewModel, Product>().ReverseMap();
        CreateMap<ProductByBarcodeViewModel, Product>().ReverseMap();

        CreateMap<UpdateInformationViewModel, Employee>().ReverseMap();
        CreateMap<ViewEmployeeListViewModel, Employee>().ReverseMap();

        CreateMap<CreatePromotionViewModel, Promotion>().ReverseMap();
        CreateMap<AddCustomerViewModel, Customer>().ReverseMap();

        CreateMap<UpdateCustomerPolicyViewModel, CustomerPolicy>().ReverseMap();
        CreateMap<CustomerPolicyViewMode, CustomerPolicy>().ReverseMap();
        CreateMap<OrderViewModel, Order>().ReverseMap();
        CreateMap<CreateOrderViewModel, Order>().ReverseMap();
        CreateMap<CreateTypePriceViewModel, TypePrice>().ReverseMap();
        CreateMap<UpdateTypePriceViewModel, TypePrice>().ReverseMap();

    }
}