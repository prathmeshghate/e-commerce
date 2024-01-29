using System.Text.Json.Serialization;

namespace DTO.productPrimaryDetails
{
    public class ProductPrimaryDetailsDTO
    {

        [JsonPropertyName("productid")]
        public int ProductId{get; set;}
        [JsonPropertyName("productName")]
        public string ProductName{get; set;}
        [JsonPropertyName("productCategory")]
        public string ProductCategory{get; set;}
        [JsonPropertyName("productSubCategory")]
        public string ProductSubCategory{get; set;}
        [JsonPropertyName("productBrand")]
        public string ProductBrand{get; set;}
        [JsonPropertyName("shopKartAssured")]
        public int ShopKartAssured{get; set;}
    }
}