using Interface.homepage;
using DTO;
using Entity.productSummary;
using DTO.product;
using Entity.product;
using System.Reflection.Emit;
using DTO.productSummary;
using System.Collections.Generic;

namespace BAL.homepage
{
    public class HomePageLogic : IHomePageLogic
    {
        private readonly IServiceProvider _container;
        private readonly IHomepageProductRepositary _homePageRepo;

        public ProductLogic(IServiceProvider container)
        {
            _container = container;
            _homepagerepo = _container.GetRequiredService<IHomepageProductRepositary>();

        }
        public List<ProductSummaryDto> GetDataAsync()
        {
            List<ProductSummaryDto> productSummaryResponse = new();
            List<ProductSummary> products = GetDealOfTheDayAsync();
            int productsLength = products.Count;

            for (int i = 0; i < productsLength; i++)
            {
                ProductSummaryDto productSummary = _mapper.Map<ProductSummaryDto>(products[i]);
                productSummaryResponse.Add(productSummary);

            }

            return productSummaryResponse;

        }

        private List<ProductSummary> GetDealOfTheDayAsync()
        {
            //repo call
            List<ProductSummary> productSummary = _homePageRepo.GetDealOfDayProductAsync();
        }
    }


}