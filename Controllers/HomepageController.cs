using System;
using System.Collections.Generic;
using BAL.homepage;
using DTO;
using DTO.productSummary;
using Interface.homepage;
using Microsoft.AspNetCore.Mvc;

namespace controller.homepage
{
    public class HomepageController : ControllerBase
    {
        private readonly IHomePageLogic _homePageLogic;

        public HomepageController( IHomePageLogic homePageLogic)
        {
            _homePageLogic = homePageLogic;
        }

        [HttpGet]
        [Route("api/deal-of-the-day")]
        public ActionResult<List<ProductSummaryDto>> DealOfTheDayAsync()
        {
            try
            {
                ProductSummaryDto productSummary = _homePageLogic.GetDataAsync();
                return Ok(productSummary);
            }
            catch (Exception ex)
            {
                return BadRequest($"Message is {ex.Message}");
            }
        }


    }
}