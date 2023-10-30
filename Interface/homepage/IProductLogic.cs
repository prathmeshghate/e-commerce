using Entity.Homepage;

namespace Interface.homepage
{
    public interface IProductLogic
    {
        List<ProductSummary> GetDataAsync();
    }
}