using Entity.product;
using utility.response;

namespace Interface.CreateUpdateRepo{

    public interface ICreateUpdateDbRepositary{
        ResponseDetails InsertProductAsync(Product product);
    }
}