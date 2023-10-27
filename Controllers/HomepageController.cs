using BAL.homepage;
using DTO;
using Microsoft.AspNetCore.Mvc;

namespace Controller;
[Route("api/[HomepageController]")]
[ApiController]
public class HomepageController : ControllerBase
{
    private readonly IServiceCollection _container;

    public HomepageController(IServiceCollection container){
        _container=container;
    }

    public IActionResult HomepageAsync()
    {
        //make a dto which will contain 
        //productName
        //makeName
        //price
        //discountedPrice
        //image
        //rating
        


        return  Ok("GotThe HitBitch");
    }


}