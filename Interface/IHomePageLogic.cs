
using Dto.product;
using DTO.productSummary;
using Entity.product;
using Entity.productDesc;
using Entity.productSummary;

namespace Interface.homepage
{
    public interface IHomePageLogic
    {
        Task<List<ProductDTO>> GetDealOfTheDayAsync();
        Task<List<Product>> GetProductWithHighestDiscountAsync();

    }
}