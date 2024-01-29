using AutoMapper;
using Dto.ProductDescription;
using DTO.productPrimaryDetails;
using DTO.productSummary;
using Entity.product;
using Entity.productDesc;
using Entity.productPrimary;
using Entity.productSummary;

namespace mapper
{
    public class GlobalMapper : Profile
    {
        public GlobalMapper()
        {
            CreateMap<ProductSummaryDTO, ProductSummary>();

            CreateMap<ProductSummary, ProductPrimaryDetails>();

            CreateMap<ProductSummary, ProductDescription>()
            .ForMember(dest => dest.ProductDesc, opt => opt.MapFrom(src => src.ProductDescription))
            .ForMember(dest => dest.Colour, opt => opt.NullSubstitute(string.Empty))
            .ForMember(dest => dest.ImagePath, opt => opt.NullSubstitute(string.Empty))
            .ForMember(dest => dest.Attribute1, opt => opt.MapFrom(src => src.Attribute1))
            .ForMember(dest => dest.Attribute1Value, opt => opt.MapFrom(src => src.Attribute1Value))
            .ForMember(dest => dest.Sku, opt => opt.MapFrom(src => SetToZero(src.Sku)));

            CreateMap<ProductPrimaryDetails, ProductPrimaryDetailsDTO>()
            .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
            .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.ProductName ?? string.Empty))
            .ForMember(dest => dest.ProductCategory, opt => opt.MapFrom(src => src.ProductCategory ?? string.Empty))
            .ForMember(dest => dest.ProductSubCategory, opt => opt.MapFrom(src => src.ProductSubCategory ?? string.Empty))
            .ForMember(dest => dest.ProductBrand, opt => opt.MapFrom(src => src.ProductBrand ?? string.Empty))
            .ForMember(dest => dest.ShopKartAssured, opt => opt.MapFrom(src => src.ShopKartAssured));

            CreateMap<ProductDescription, ProductDescriptionDTO>()
            .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
            .ForMember(dest => dest.ProductDescriptionId, opt => opt.MapFrom(src => src.ProductDescriptionId))
            .ForMember(dest => dest.Colour, opt => opt.MapFrom(src => src.Colour ?? string.Empty))
            .ForMember(dest => dest.ImagePath, opt => opt.MapFrom(src => src.ImagePath ?? string.Empty))
            .ForMember(dest => dest.Attribute1, opt => opt.MapFrom(src => src.Attribute1 ?? string.Empty))
            .ForMember(dest => dest.Attribute1Value, opt => opt.MapFrom(src => src.Attribute1Value ?? string.Empty))
            .ForMember(dest => dest.Attribute2, opt => opt.MapFrom(src => src.Attribute2 ?? string.Empty))
            .ForMember(dest => dest.Attribute2Value, opt => opt.MapFrom(src => src.Attribute2Value ?? string.Empty))
            .ForMember(dest => dest.Attribute3, opt => opt.MapFrom(src => src.Attribute3 ?? string.Empty))
            .ForMember(dest => dest.Attribute3Value, opt => opt.MapFrom(src => src.Attribute3Value ?? string.Empty))
            .ForMember(dest => dest.ProductDescription, opt => opt.MapFrom(src => src.ProductDesc ?? string.Empty));


        }
        private static int SetToZero(string sku)
        {
            return 0;
        }

    }
}