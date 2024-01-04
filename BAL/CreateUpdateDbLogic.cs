using AutoMapper;
using Entity.product;
using Entity.productDesc;
using Entity.productPrimary;
using Entity.productSummary;
using Interface.CreateUpdate;
using Interface.CreateUpdateRepo;
using utility.DbResponse;
using utility.response;
using utility.Validation;

namespace BAL.CreateUpdate
{
    public class CreateUpdateDbLogic : ICreateUpdateDbLogic
    {

        private readonly IServiceProvider _container;
        private readonly IMapper _mapper;
        private readonly ICreateUpdateDbRepositary _createUpdateDbRepositary;

        public CreateUpdateDbLogic(IServiceProvider container, IMapper mapper, ICreateUpdateDbRepositary createUpdateDbRepositary)
        {
            _container = container;
            _mapper = mapper;
            _createUpdateDbRepositary = createUpdateDbRepositary;
        }

        public async Task<ResponseDetails> InsertProductAsync(ProductSummary productSummary)
        {
            try
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

                DbResponseDetails primaryDataResponse = await _createUpdateDbRepositary.InsertPrimaryDetailsAsync(products[0].ProductPrimaryDetails);

                for (int i = 0; i < productsLength; i++)
                {
                    response = await _createUpdateDbRepositary.InsertDescriptionAsync(products[i].ProductDescription,primaryDataResponse.IncrementedId);
                }

                // write the logic of creating new productId and productDescriptionId here

                return response;
            }
            catch (Exception ex)
            {
                return new ResponseDetails { Message = ex.Message };
            }

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