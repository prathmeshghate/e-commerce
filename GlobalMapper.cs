using AutoMapper;
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
            CreateMap<ProductSummaryDto, ProductSummary>();

            CreateMap<ProductSummary, ProductPrimaryDetails>();

            CreateMap<ProductSummary, ProductDescription>()
            .ForMember(dest => dest.ProductDesc, opt => opt.MapFrom(src => src.ProductDescription))
            .ForMember(dest => dest.Colour, opt => opt.NullSubstitute(string.Empty))
            .ForMember(dest => dest.ImagePath, opt => opt.NullSubstitute(string.Empty))
            .ForMember(dest => dest.Attribute1, opt => opt.MapFrom(src => src.Attribute1))
            .ForMember(dest => dest.Attribute1Value, opt => opt.MapFrom(src => src.Attribute1Value))
            .ForMember(dest => dest.Sku, opt => opt.MapFrom(src => SetToZero(src.Sku)));

        }
        private int SetToZero(string sku)
        {
            return 0;
        }

    }
}