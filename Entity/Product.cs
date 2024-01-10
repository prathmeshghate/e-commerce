using Entity.productDesc;
using Entity.productPrimary;

namespace Entity.product
{
    public class Product
    {
        // public Product(ProductPrimaryDetails primaryDetails, ProductDescription description)
        // {
        //     ProductPrimaryDetails = primaryDetails;
        //     ProductDescription = description;
        // }

        public ProductPrimaryDetails ProductPrimaryDetails { get; set; }

        public ProductDescription ProductDescription { get; set; }

    }
}