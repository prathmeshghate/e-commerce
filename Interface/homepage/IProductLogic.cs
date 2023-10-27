using DTO;

namespace Interface.homepage;

public interface IProductLogic
{
    List<ProductInfoDto> GetDataAsync();
}