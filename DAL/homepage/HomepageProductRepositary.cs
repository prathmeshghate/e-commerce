using DTO;
using Interface.homepage;

namespace DAL.homepage;

public class HomepageProductRepositary : IHomepageProductRepositary
{

    private readonly IServiceCollection _container;

    public HomepageProductRepositary(IServiceCollection container)
    {
        _container = container;
    }

    public ProductInfoDto GetAllHomepageProduct()
    {
        return new ProductInfoDto();
    }
}