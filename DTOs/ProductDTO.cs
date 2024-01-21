using Dto.ProductDescription;
using DTO.productPrimaryDetails;
using Newtonsoft.Json;

namespace Dto.product
{
    public class ProductDTO
    {

        [JsonProperty("productPrimaryDetails")]
        public ProductPrimaryDetailsDTO ProductPrimaryDetails { get; set; }
        
        [JsonProperty("productDescription")]
        public ProductDescriptionDTO ProductDescription { get; set; }

    }
}