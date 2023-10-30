using System.Text.Json.Serialization;

namespace DTO
{
    public class ProductInfoDTO
    {
        [JsonPropertyName("productName")]
        string ProductName;
        [JsonPropertyName("makeName")]
        string MakeName;
        [JsonPropertyName("price")]
        uint Price;
        [JsonPropertyName("discountedPrice")]
        uint DiscountedPrice;
        [JsonPropertyName("imagePath")]
        string ImagePath;
        [JsonPropertyName("rating")]
        float Rating;
    }
}