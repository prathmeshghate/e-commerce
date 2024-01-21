using System;
using System.Collections.Generic;
using BAL.homepage;
using Dto.product;
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
        public async Task<ActionResult<List<ProductDTO>>> DealOfTheDayAsync()
        {
            try
            {
                List<ProductDTO> productSummary = await _homePageLogic.GetDealOfTheDayAsync();
                return Ok(productSummary);
            }
            catch (Exception ex)
            {
                return BadRequest($"Message is {ex.Message}");
            }
        }


    }
}