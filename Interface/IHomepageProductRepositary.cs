using DTO;
using DTO.product;
using Entity.product;

namespace Interface.homepage
{
    public interface IHomepageProductRepositary
    {
        List<ProductSummary> GetAllHomepageProduct();
    }
}