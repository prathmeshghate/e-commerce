using Entity.productDesc;
using Entity.productPrimary;

namespace Entity.product
{
    public class Product
    {
        public ProductPrimaryDetails ProductPrimaryDetails { get; set; }

        public ProductDescription ProductDescription { get; set; }

    }
}