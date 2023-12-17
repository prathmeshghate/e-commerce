using DTO.productSummary;
using utility.ValidationDetail;


namespace utility.Validation
{
    public static class Validation
    {

        public static ValidationDetails ValidateProductInfoDto(ProductSummaryDto productRequest)
        {
            ValidationDetails response = new();

            if (productRequest == null)
            {
                response.PropertyName = "The Dto is null";
                return response;
            }
            if (string.IsNullOrWhiteSpace(productRequest.productName))
            {
                response.PropertyName = "productName";
                return response;
            }
            if (string.IsNullOrWhiteSpace(productRequest.productCategory))
            {
                response.PropertyName = "productCategory";
                return response;
            }
            if (string.IsNullOrWhiteSpace(productRequest.productSubCategory))
            {
                response.PropertyName = "productSubCategory";
                return response;
            }
            if (string.IsNullOrWhiteSpace(productRequest.productBrand))
            {
                response.PropertyName = "productBrand";
                return response;
            }
            if (string.IsNullOrWhiteSpace(productRequest.productBrand))
            {
                response.PropertyName = "productBrand";
                return response;
            }
            if (productRequest.productPrice == 0)
            {
                response.PropertyName = "productBrand";
                return response;
            }
            if (productRequest.sku == 0)
            {
                response.PropertyName = "productBrand";
                return response;
            }

            response.IsValidRequest = true;
            return response;

        }
    }
}