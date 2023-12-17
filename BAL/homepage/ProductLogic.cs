using Interface.homepage;
using DTO;
using Entity.productSummary;
using DTO.product;

namespace BAL.homepage
{
    public class ProductLogic : IProductLogic
    {
        private readonly IServiceProvider _container;
        private readonly IHomepageProductRepositary _homepagerepo;

        public ProductLogic(IServiceProvider container)
        {
            _container = container;
            _homepagerepo=_container.GetRequiredService<IHomepageProductRepositary>();
            
        }
        public List<ProductSummary> GetDataAsync()
        {
            ProductDTO x=_homepagerepo.GetAllHomepageProduct();

            return new List<ProductSummary>();

        }
    }


}