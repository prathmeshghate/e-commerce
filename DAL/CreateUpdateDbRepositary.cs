using Entity.product;
using Interface.CreateUpdate;
using Interface.CreateUpdateRepo;
using utility.response;

namespace DAL.CreateUpdate
{
    public class CreateUpdateDbRepositary : ICreateUpdateDbRepositary
    {

        //Db conncection

        public ResponseDetails InsertProductAsync(Product product)
        {

            return new ResponseDetails();

        }

    }
}