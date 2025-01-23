using AutoMapper;
using PharmacyAPI.Models;
using PharmacyAPI.Models.DTOs;


namespace PharmacyAPI.Mapping
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserDto,User>().ReverseMap();
            CreateMap<TransactionStatusDto, TransactionStatus>().ReverseMap();
            CreateMap<TransactionDto, Transaction>().ReverseMap();
            CreateMap<TagDto, Tag>().ReverseMap();
            CreateMap<ProductTagDto, ProductsTag>().ReverseMap();
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<PriceHistoryDto, PriceHistory>().ReverseMap();
            CreateMap<PaymentStatusDto, PaymentStatus>().ReverseMap();
            CreateMap<PaymentDto, Payment>().ReverseMap();
            CreateMap<OrderStatusDto, OrderStatus>().ReverseMap();
            CreateMap<OrderDto, Order>().ReverseMap();
            CreateMap<OrderDetailsDto, OrderDetails>().ReverseMap();
            CreateMap<DeliveryStatusDto, DeliveryStatus>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<BrandDto, Brand>().ReverseMap();
            CreateMap<AddressDto, Address>().ReverseMap();
        }
    }
}
