using Interface.homepage;
using DTO;
using Entity.productSummary;
using Entity.product;
using System.Reflection.Emit;
using DTO.productSummary;
using System.Collections.Generic;
using AutoMapper;
using Dto.product;
using Entity.productPrimary;
using DTO.productPrimaryDetails;
using Dto.ProductDescription;

namespace BAL.homepage
{
    public class HomePageLogic : IHomePageLogic
    {
        private readonly IServiceProvider _container;
        private readonly IMapper _mapper;
        private readonly IHomepageProductRepositary _homePageRepo;

        public HomePageLogic(IServiceProvider container,IMapper mapper)
        {
            _container = container;
            _mapper=mapper;
            _homePageRepo = _container.GetRequiredService<IHomepageProductRepositary>();

        }
        public async Task<List<ProductDTO>> GetDealOfTheDayAsync()
        {
            List<ProductDTO> productSummaryResponse = new();
            List<Product> products = await GetProductWithHighestDiscountAsync();
            int productsLength = products.Count;

            for (int i = 0; i < productsLength; i++)
            {
                ProductDTO product=new();
                //write a mapper
                product.ProductPrimaryDetails=_mapper.Map<ProductPrimaryDetailsDTO>(products[i].ProductPrimaryDetails);
                product.ProductDescription=_mapper.Map<ProductDescriptionDTO>(products[i].ProductDescription);
                productSummaryResponse.Add(product);

            }

            return productSummaryResponse;

        }

        public async Task<List<Product>> GetProductWithHighestDiscountAsync()
        {
            //repo call
            List<Product> products = await _homePageRepo.GetDealOfDayProductAsync();

            return products;
        }
    }


}