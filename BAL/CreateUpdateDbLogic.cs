using AutoMapper;
using Entity.product;
using Entity.productDesc;
using Entity.productPrimary;
using Entity.productSummary;
using Interface.CreateUpdate;
using Interface.CreateUpdateRepo;
using utility.response;

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
            ResponseDetails response = new();
            if (!ColorsAndImageInputForamatChecker(productSummary, response))
            {
                return response;
            }

            Product Product = new();
            List<string> Colours = new List<string>(productSummary.Colours.Split(","));

            List<Product> products = IntoSingleEntity(productSummary);
            int productsLength = products.Count;
            for (int i = 0; i < productsLength; i++)
            {

                response = _createUpdateDbRepositary.InsertProductAsync(products[i]);

            }





            // write the logic of creating new productId and productDescriptionId here

            return response;

        }

        private bool ColorsAndImageInputForamatChecker(ProductSummary productSummary, ResponseDetails response)
        {
            //I get following this into a mulitple format
            //colours
            //imagePaths
            //sku
            List<string> Colours = new List<string>(productSummary.Colours.Split(","));
            List<string> ImagePaths = new List<string>(productSummary.ImagePaths.Split(","));
            List<string> sku = new List<string>(productSummary.Sku.Split(","));

            //allowed cases colours.Count==imagePath.Count && imagepath.Count ==1
            //imagePaths and Colours
            if (ImagePaths.Count != Colours.Count)
            {
                response.Message = "Colours and Imagepath are not correct format";
                return false;
            }
            //imagePaths and sku
            if (sku.Count != ImagePaths.Count)
            {
                response.Message = "sku and Imagepath are not correct format";
                return false;
            }
            //sku and Colours
            if (sku.Count != Colours.Count)
            {
                response.Message = "Colours and sku are not correct format";
                return false;
            }
            return true;
        }

        private List<Product> IntoSingleEntity(ProductSummary productSummary)
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

            List<Product> individualProduct= new List<Product>();
            productPrimaryDetails = _mapper.Map<ProductPrimaryDetails>(productSummary);
            productDescription = _mapper.Map<ProductDescription>(productSummary);


            for (int i = 0; i < ColoursLength; i++)
            {
                productDescription.Colour=Colours[i];
                productDescription.ImagePath=ImagePaths[i];
                productDescription.Sku=sku[i];
            }

            return product;


        }
    }
}