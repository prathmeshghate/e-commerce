
using Entity.productSummary;

namespace Interface.homepage
{
    public interface IProductLogic
    {
        List<ProductSummary> GetDataAsync();
    }
}