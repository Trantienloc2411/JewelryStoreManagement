using AutoMapper;
using DataLayer.Entities;
using JewelryStoreManagement.ViewModels;
using JSMServices.ViewModels.CustomerViewModel;
using JSMServices.ViewModels.CustomerPolicyViewModel;
using JSMServices.ViewModels.ProductViewModel;
using JSMServices.ViewModels.PromotionViewModel;

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
        CreateMap<ViewEmployeeListViewModel, Employee>().ReverseMap()
        .ForMember(dest => dest.CounterName, opt => opt.MapFrom(src => src.Counter.CounterName));


        CreateMap<CreatePromotionViewModel, Promotion>().ReverseMap();
        CreateMap<AddCustomerViewModel, Customer>().ReverseMap();

        CreateMap<UpdateCustomerPolicyViewModel, CustomerPolicy>().ReverseMap();
        CreateMap<CustomerPolicyViewMode, CustomerPolicy>().ReverseMap();

    }
}