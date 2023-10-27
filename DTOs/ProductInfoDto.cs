using System.Text.Json.Serialization;

namespace DTO;

public class ProductInfoDto
{
    [JsonPropertyName("ProductName")]
    string ProductName;
    [JsonPropertyName("MakeName")]
    string MakeName;
    [JsonPropertyName("Price")]
    uint Price;
    [JsonPropertyName("DiscountedPrice")]
    uint DiscountedPrice;
    [JsonPropertyName("ImagePath")]
    string ImagePath;
    [JsonPropertyName("Rating")]
    float Rating;
}