using System.Text.Json.Serialization;

namespace DTO.productSummary
{

    public class ProductSummaryDto
    {

        [JsonPropertyName("productid")]
        public int Productid { get; set; }
        [JsonPropertyName("productName")]
        public string ProductName { get; set; }
        [JsonPropertyName("productCategory")]
        public string ProductCategory { get; set; }
        [JsonPropertyName("productSubCategory")]
        public string productSubCategory { get; set; }
        [JsonPropertyName("productBrand")]
        public string ProductBrand { get; set; }
        [JsonPropertyName("shopKartAssured")]
        public int ShopKartAssured { get; set; }
        [JsonPropertyName("productDescriptionId")]
        public int ProductDescriptionId { get; set; }
        [JsonPropertyName("colours")]
        public string Colours { get; set; }
        [JsonPropertyName("imagepaths")]
        public string ImagePaths{get; set;}
        [JsonPropertyName("attribute1")]
        public string Attribute1 { get; set; }
        [JsonPropertyName("attribute1Value")]
        public string Attribute1Value { get; set; }
        [JsonPropertyName("attribute2")]
        public string Attribute2 { get; set; }
        [JsonPropertyName("attribute2Value")]
        public string Attribute2Value { get; set; }
        [JsonPropertyName("attribute3")]
        public string Attribute3 { get; set; }
        [JsonPropertyName("attribute3Value")]
        public string Attribute3Value { get; set; }
        [JsonPropertyName("productDescription")]
        public string ProductDescription { get; set; }
        [JsonPropertyName("productPrice")]
        public float ProductPrice { get; set; }
        [JsonPropertyName("productDiscount")]
        public float ProductDiscount { get; set; }
        [JsonPropertyName("sku")]
        public string Sku { get; set; }
        [JsonPropertyName("rating")]
        public float Rating { get; set; }

    }
}