using DTO;
using Entity.product;
using Entity.productDesc;
using Entity.productPrimary;

namespace Interface.homepage
{
    public interface IHomepageProductRepositary
    {
        Task<List<Product>> GetDealOfDayProductAsync();
        Task<List<ProductDescription>> GetProductDescWithHighestDiscountAsync();
        Task<ProductPrimaryDetails> GetProductPrimaryDetails(int productId);
    }
}