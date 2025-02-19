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
            CreateMap<AddUserDto, User>().ReverseMap();
            CreateMap<UpdateUserDto, User>().ReverseMap();
            CreateMap<TransactionStatusDto, TransactionStatus>().ReverseMap();
            CreateMap<AddTransactionStatusDto, TransactionStatus>().ReverseMap();
            CreateMap<UpdateTransactionStatusDto, TransactionStatus>().ReverseMap();
            CreateMap<TransactionDto, Transaction>().ReverseMap();
            CreateMap<AddTransactionDto, Transaction>().ReverseMap();
            CreateMap<UpdateTransactionDto, Transaction>().ReverseMap();
            CreateMap<TagDto, Tag>().ReverseMap();
            CreateMap<AddTagDto, Tag>().ReverseMap();
            CreateMap<UpdateTagDto, Tag>().ReverseMap();
            CreateMap<ProductTagDto, ProductsTag>().ReverseMap();
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<AddProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();
            CreateMap<PriceHistoryDto, PriceHistory>().ReverseMap();
            CreateMap<AddPriceHistoryDto, PriceHistory>().ReverseMap();
            CreateMap<UpdatePriceHistoryDto, PriceHistory>().ReverseMap();
            CreateMap<PaymentStatusDto, PaymentStatus>().ReverseMap();
            CreateMap<AddPaymentStatusDto, Payment>().ReverseMap();
            CreateMap<UpdatePaymentStatusDto, PaymentStatus>().ReverseMap();
            CreateMap<PaymentDto, Payment>().ReverseMap();
            CreateMap<AddPaymentDto, Payment>().ReverseMap();
            CreateMap<UpdatePaymentDto, Payment>().ReverseMap();
            CreateMap<OrderStatusDto, OrderStatus>().ReverseMap();
            CreateMap<AddOrderStatusDto, Order>().ReverseMap();
            CreateMap<UpdateOrderStatusDto, OrderStatus>().ReverseMap();
            CreateMap<OrderDto, Order>().ReverseMap();
            CreateMap<AddOrderDto, Order>().ReverseMap();
            CreateMap<UpdateOrderDto, Order>().ReverseMap();
            CreateMap<OrderDetailsDto, OrderDetails>().ReverseMap();
            CreateMap<AddOrderDetailsDto, OrderDetails>().ReverseMap();
            CreateMap<UpdateOrderDetailsDto, OrderDetails>().ReverseMap();
            CreateMap<DeliveryStatusDto, DeliveryStatus>().ReverseMap();
            CreateMap<AddDeliveryStatusDto, DeliveryStatus>().ReverseMap();
            CreateMap<UpdateDeliveryStatusDto, DeliveryStatus>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<AddCategoryDto, Category>().ReverseMap();
            CreateMap<UpdateCategoryDto, Category>().ReverseMap();
            CreateMap<BrandDto, Brand>().ReverseMap();
            CreateMap<AddBrandDto, Brand>().ReverseMap();
            CreateMap<UpdateBrandDto, Brand>().ReverseMap();
            CreateMap<AddressDto, Address>().ReverseMap();
            CreateMap<AddAddressDto, Address>().ReverseMap();
            CreateMap<UpdateAddressDto, Address>().ReverseMap();
        }
    }
}
