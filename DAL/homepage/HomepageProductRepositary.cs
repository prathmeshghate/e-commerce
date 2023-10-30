using DTO;
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

        public ProductInfoDTO GetAllHomepageProduct()
        {
            return new ProductInfoDTO();
        }
    }
}