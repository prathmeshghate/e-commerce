using BAL.CreateUpdate;
using Entity.product;
using Entity.productSummary;
using utility.response;
using utility.ValidationDetail;
using DTO.productSummary;
using Entity.user;
using ZstdSharp.Unsafe;


namespace utility.Validation
{
    public static class Validation
    {

        public static ValidationDetails ValidateProductInfoDto(ProductSummaryDTO productRequest)
        {
            ValidationDetails response = new();

            if (productRequest == null)
            {
                response.PropertyName = "The Dto is null";
                return response;
            }
            if (string.IsNullOrWhiteSpace(productRequest.ProductName))
            {
                response.PropertyName = "productName";
                return response;
            }
            if (string.IsNullOrWhiteSpace(productRequest.ProductCategory))
            {
                response.PropertyName = "productCategory";
                return response;
            }
            if (string.IsNullOrWhiteSpace(productRequest.productSubCategory))
            {
                response.PropertyName = "productSubCategory";
                return response;
            }
            if (string.IsNullOrWhiteSpace(productRequest.ProductBrand))
            {
                response.PropertyName = "productBrand";
                return response;
            }
            if (string.IsNullOrWhiteSpace(productRequest.Colours))
            {
                response.PropertyName = "Colours";
                return response;
            }
            if (productRequest.ProductPrice == 0)
            {
                response.PropertyName = "ProductPrice";
                return response;
            }
            if (string.IsNullOrWhiteSpace(productRequest.Sku))
            {
                response.PropertyName = "Sku";
                return response;
            }
            if (string.IsNullOrWhiteSpace(productRequest.ImagePaths))
            {
                response.PropertyName = "ImagePaths";
                return response;
            }

            response.IsValidRequest = true;
            return response;

        }

        public static ResponseDetails ValidateProudctSummary(ProductSummary productSummary)
        {
            ResponseDetails response = new();
            List<string> Colours = new List<string>(productSummary.Colours.Split(","));
            List<string> ImagePaths = new List<string>(productSummary.ImagePaths.Split(","));
            List<string> sku = new List<string>(productSummary.Sku.Split(","));
            if (productSummary == null)
            {
                response.Message = ("product found null in", nameof(CreateUpdateDbLogic)).ToString();
                return response;
            }

            if (ImagePaths.Count != Colours.Count)
            {
                response.Message = "Colours and Imagepath are not correct format";
                return response;
            }
            if (sku.Count != ImagePaths.Count)
            {
                response.Message = "sku and Imagepath are not correct format";
                return response;
            }
            if (sku.Count != Colours.Count)
            {
                response.Message = "Colours and sku are not correct format";
                return response;
            }
            response.IsValid = true;
            return response;
        }

        public static ResponseDetails ValidateUserRequest(User user)
        {
            ResponseDetails response = new();
            if (String.IsNullOrEmpty(user.MobileNo))
            {
                response.Message = "mobile number is empty";
                return response;
            }
            if (String.IsNullOrEmpty(user.Password))
            {
                response.Message = "Password is empty";
                return response;
            }
            response.Message = "Valid input details";
            response.IsValid = true;
            return response;

        }

    }

}