using AutoMapper;
using DTO.productSummary;
using Entity.productSummary;

namespace mapper
{
    public class GlobalMapper : Profile
    {
        public GlobalMapper()
        {
            CreateMap<ProductSummaryDto, ProductSummary>();
        }

    }
}