using Entity.productSummary;
using utility.response;

namespace Interface.CreateUpdate
{
    public interface ICreateUpdateDbLogic
    {
        ResponseDetails InsertProductAsync(ProductSummary productSummary);
    }
}