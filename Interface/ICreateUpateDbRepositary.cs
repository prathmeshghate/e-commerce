using Entity.productDesc;
using Entity.productPrimary;
using utility.DbResponse;
using utility.response;

namespace Interface.CreateUpdateRepo
{
    public interface ICreateUpdateDbRepositary
    {
        Task<DbResponseDetails> InsertPrimaryDetailsAsync(ProductPrimaryDetails product);
        Task<ResponseDetails> InsertDescriptionAsync(ProductDescription product, long incrementedId);
    }
}