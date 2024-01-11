using System.Collections.Generic;
using DTO;
using DTO.product;
using Entity.product;
using Entity.productSummary;
using Interface.homepage;

namespace DAL.homepage
{
    public class HomepageProductRepositary : IHomepageProductRepositary
    {


        public HomepageProductRepositary(IServiceProvider container)
        {
            _container = container;
        }

        public List<ProductSummary> HighestDiscountProductAsync(){
            string cmd=@"SELECT * FROM ecommerce."
        }
    }
}