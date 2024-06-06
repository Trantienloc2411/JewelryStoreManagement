using AutoMapper;
using DataLayer.Entities;
using JewelryStoreManagement.ViewModels;
using JSMServices.ViewModels.ProductViewModel;

namespace JewelryStoreManagement.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<RegisterEmployeeViewModel, Employee>().ReverseMap();
        CreateMap<LoginEmployeeViewModel, Employee>().ReverseMap();
        CreateMap<ProductViewModel, Product>().ReverseMap();
    }
}