using DTO;
using DTO.product;

namespace Interface.homepage
{
    public interface IHomepageProductRepositary
    {
        ProductDTO GetAllHomepageProduct();
    }
}