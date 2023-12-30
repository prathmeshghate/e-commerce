using AutoMapper;
using Entity.product;
using Entity.productDesc;
using Entity.productPrimary;
using Entity.productSummary;
using Interface.CreateUpdate;
using Interface.CreateUpdateRepo;
using utility.response;
using utility.Validation;

namespace BAL.CreateUpdate
{
    public class CreateUpdateDbLogic : ICreateUpdateDbLogic
    {

        private readonly IServiceProvider _container;
        private readonly IMapper _mapper;
        private readonly ICreateUpdateDbRepositary _createUpdateDbRepositary;

        public CreateUpdateDbLogic(IServiceProvider container, IMapper mapper)
        {
            _container = container;
            _mapper = mapper;
        }

        public ResponseDetails InsertProductAsync(ProductSummary productSummary)
        {
            ResponseDetails response = Validation.ValidateProudctSummary(productSummary);
            if (!response.IsValid)
            {
                return response;
            }

            Product Product = new();
            List<string> Colours = new List<string>(productSummary.Colours.Split(","));
            List<Product> products = IntoIndividualProduct(productSummary);
            int productsLength = products.Count;
            
            for (int i = 0; i < productsLength; i++)
            {
                response = _createUpdateDbRepositary.InsertProductAsync(products[i]);
            }

            // write the logic of creating new productId and productDescriptionId here

            return response;

        }

        private List<Product> IntoIndividualProduct(ProductSummary productSummary)
        {
            //I get following this into a mulitple format
            //sku
            //colours
            //imagePaths

            List<string> Colours = new List<string>(productSummary.Colours.Split(","));
            List<string> ImagePaths = new List<string>(productSummary.ImagePaths.Split(","));
            List<string> skuOfString = new List<string>(productSummary.Sku.Split(","));
            List<int> sku = skuOfString.ConvertAll(int.Parse);
            int ColoursLength = Colours.Count;

            ProductPrimaryDetails productPrimaryDetails = new();
            ProductDescription productDescription = new();
            Product product = new();

            List<Product> products = new List<Product>();
            productPrimaryDetails = _mapper.Map<ProductPrimaryDetails>(productSummary);
            productDescription = _mapper.Map<ProductDescription>(productSummary);


            for (int i = 0; i < ColoursLength; i++)
            {
                productDescription.Colour = Colours[i];
                productDescription.ImagePath = ImagePaths[i];
                productDescription.Sku = sku[i];

                product.ProductPrimaryDetails = productPrimaryDetails;
                product.ProductDescription = productDescription;
                products.Add(product);
            }

            return products;


        }
    }
}