using AutoMapper;
using DataLayer.Entities;
using JewelryStoreManagement.ViewModels;
using JSMServices.ViewModels.CounterViewMode;
using JSMServices.ViewModels.CustomerPolicyViewModel;
using JSMServices.ViewModels.CustomerViewModel;
using JSMServices.ViewModels.EmployeeViewModel;
using JSMServices.ViewModels.GiftViewModel;
using JSMServices.ViewModels.OrderViewModel;
using JSMServices.ViewModels.ProductViewModel;
using JSMServices.ViewModels.PromotionViewModel;
using JSMServices.ViewModels.TypePriceViewModel;
using JSMServices.ViewModels.WarrantyViewModel;

namespace JewelryStoreManagement.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<RegisterEmployeeViewModel, Employee>().ReverseMap();
        CreateMap<LoginEmployeeViewModel, Employee>().ReverseMap();
        CreateMap<TypePrice, TypePrice>()
            .ForMember(dest => dest.Products, opt => opt.Ignore());

        CreateMap<ProductViewById, Product>().ReverseMap()
            .ForMember(dest => dest.Counter, opt => opt.MapFrom(src => src.Counter));
        CreateMap<Product, ProductViewModel>()
            .ForMember(dest => dest.CounterName, opt => opt.MapFrom(src => src.Counter.CounterName))
            .ForMember(dest => dest.TypePrice, opt => opt.MapFrom(src => src.TypePrice));
        CreateMap<ProductByCounterIdViewModel, Product>().ReverseMap()
            .ForMember(dest => dest.TypeName, opt => opt.MapFrom(src => src.TypePrice.TypeName));
        CreateMap<AddProductViewModel, Product>().ReverseMap();
        CreateMap<UpdateProductViewModel, Product>().ReverseMap();
        CreateMap<ProductByBarcodeViewModel, Product>().ReverseMap();

        CreateMap<UpdateInformationViewModel, Employee>().ReverseMap();
        CreateMap<ViewEmployeeListViewModel, Employee>().ReverseMap()
        .ForMember(dest => dest.CounterName, opt => opt.MapFrom(src => src.Counter.CounterName));
        CreateMap<ViewEmployeeByCounterId, Employee>().ReverseMap();

        CreateMap<CreatePromotionViewModel, Promotion>().ReverseMap();
        CreateMap<PromotionViewModel, Promotion>().ReverseMap();
        CreateMap<ICollection<PromotionViewModel>, ICollection<Promotion>>().ReverseMap();
        CreateMap<AddCustomerViewModel, Customer>().ReverseMap();

        CreateMap<UpdateCustomerPolicyViewModel, CustomerPolicy>().ReverseMap();
        CreateMap<CustomerPolicyViewMode, CustomerPolicy>().ReverseMap();
        CreateMap<OrderViewModel, Order>().ReverseMap();
        CreateMap<CreateTypePriceViewModel, TypePrice>().ReverseMap();
        CreateMap<UpdateTypePriceViewModel, TypePrice>().ReverseMap();
        CreateMap<AddNewCounterViewModel, Counter>().ReverseMap();
        CreateMap<CounterViewModel, Counter>().ReverseMap();
        CreateMap<AssignCounterToViewModel, Employee>().ReverseMap();
        CreateMap<CreateGiftViewModel, Gift>().ReverseMap();
        CreateMap<CreateRequestCustomerPolicyViewModel, CustomerPolicy>().ReverseMap();
        CreateMap<UpdateWarrantyViewModel, Warranty>().ReverseMap();

        CreateMap<CreateWarrantyViewModel, Warranty>().ReverseMap();
        CreateMap<GiftViewModel, Gift>().ReverseMap();
        CreateMap<OrderOrderDetailByCounterIdViewModel, Order>().ReverseMap();
        CreateMap<OrderOrderDetailByCounterIdViewModel, OrderDetail>().ReverseMap();
        
        CreateMap<DataLayer.Entities.Promotion, JSMServices.ViewModels.PromotionViewModel.PromotionViewModel>().ReverseMap();
        CreateMap<ICollection<DataLayer.Entities.Promotion>, List<JSMServices.ViewModels.PromotionViewModel.PromotionViewModel>>().ReverseMap();
    }
}