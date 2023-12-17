using BAL.homepage;
using DTO.product;
using AutoMapper;
using DTO.productSummary;
using Entity.product;
using Entity.productSummary;
using Interface.homepage;
using Microsoft.AspNetCore.Mvc;
using utility.Validation;
using utility.ValidationDetail;
using Interface.CreateUpdate;
using Interface;
using utility.RequestDetails;
using BAL.CreateUpdate;
using utility.response;

namespace controller.createProduct
{

    public class CreateUpdateProductController : Controller
    {

        private readonly IServiceProvider _container;
        private readonly IMapper _mapper;
        private readonly ICreateUpdateDbLogic _createUpdateDbLogic;

        public CreateUpdateProductController(IServiceProvider container, ICreateUpdateDbLogic createUpdateDbLogic, IMapper mapper)
        {
            _container = container;
            // _productLogic=container.GetRequiredService<IProductLogic>()
            _createUpdateDbLogic = createUpdateDbLogic;
            _mapper = mapper;
        }
        [HttpPost]
        [Route("api/create-product")]
        public IActionResult InsertProduct([FromBody] ProductSummaryDto productRequest)
        {
            ValidationDetails request = Validation.ValidateProductInfoDto(productRequest);

            if (!request.IsValidRequest)
            {
                RequestDetails errorDetails = new RequestDetails("BadRequest, The mentioned property is null: ", request.PropertyName);
                return BadRequest(errorDetails);
            }
            //Mapper
            ProductSummary productSummary = _mapper.Map<ProductSummary>(productRequest);

            ResponseDetails result = _createUpdateDbLogic.InsertProductAsync(productSummary);

            return Ok(result);

        }
    }
}