using AutoMapper;
using DataLayer.Entities;
using JewelryStoreManagement.ViewModels;
using JSMServices.ViewModels.CustomerPolicyViewModel;
using JSMServices.ViewModels.ProductViewModel;

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
        CreateMap<UpdateCustomerPolicyViewModel, CustomerPolicy>().ReverseMap();
        CreateMap<CustomerPolicyViewMode, CustomerPolicy>().ReverseMap();

    }
}