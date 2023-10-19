using BAL.homepage;
using DTO;
using Microsoft.AspNetCore.Mvc;

namespace Controller;

public class HomepageController : ControllerBase
{
    [Route("api/homepage")]
    public async Task<string> HomepageAsync()
    {
        //make a dto which will contain 
        //productName
        //makeName
        //price
        //discountedPrice
        //image
        //rating
        ProductLogic productLogic=new();
        List<ProductInfo> products = await productLogic.GetDataAsync();


        return "GotThe HitBitch";
    }


}