using System.Text.Json.Serialization;

namespace Dto.ProductDescription
{
    public class ProductDescriptionDTO
    {
        [JsonPropertyName("productId")]
        public int ProductId {get; set;}
        [JsonPropertyName("productDescriptionId")]
        public int ProductDescriptionId { get; set; }
        [JsonPropertyName("colour")]
        public string Colour { get; set; }
        [JsonPropertyName("imagePath")]
        public string ImagePath { get; set; }
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
        public int Sku { get; set; }
        [JsonPropertyName("rating")]
        public float Rating { get; set; }
    }
}