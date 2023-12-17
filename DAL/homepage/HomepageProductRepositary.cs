using DTO;
using DTO.product;
using Interface.homepage;

namespace DAL.homepage
{
    public class HomepageProductRepositary : IHomepageProductRepositary
    {

        private readonly IServiceProvider _container;

        public HomepageProductRepositary(IServiceProvider container)
        {
            _container = container;
        }

        public ProductDTO GetAllHomepageProduct()
        {
            return new ProductDTO();
        }
    }
}