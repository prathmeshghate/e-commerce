using Entity.productSummary;
using utility.response;

namespace Interface.CreateUpdate
{
    public interface ICreateUpdateDbLogic
    {
        Task<ResponseDetails> InsertProductAsync(ProductSummary productSummary);
    }
}