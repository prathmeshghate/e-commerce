using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using utility.helper;
using utility.RequestDetails;
using utility.response;
using utility.Validation;
using utility.ValidationDetail;

namespace controller.register.login
{
    public class RegisterAndLoginController : Controller
    {

        [HttpPost]
        [Route("api/register")]
        public async Task<ActionResult<ResponseDetails>> RegisterUserAsync(User user)
        {
            ResponseDetails request = Validation.ValidateUserRequest(user);

            if (!request.IsValid)
            {
                return BadRequest(request);
            }

        }
    }
}