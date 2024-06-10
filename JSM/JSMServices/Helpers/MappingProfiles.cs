using AutoMapper;
using DataLayer.Entities;
using JewelryStoreManagement.ViewModels;

namespace JewelryStoreManagement.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<RegisterEmployeeViewModel, Employee>().ReverseMap();
        CreateMap<LoginEmployeeViewModel, Employee>().ReverseMap();
        CreateMap<UpdateInformationViewModel, Employee>().ReverseMap();
        CreateMap<ViewEmployeeListViewModel, Employee>().ReverseMap();
    }
}