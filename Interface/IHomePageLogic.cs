
using Entity.productSummary;

namespace Interface.homepage
{
    public interface IHomePageLogic
    {
        List<ProductSummaryDto> GetDataAsync();
    }
}