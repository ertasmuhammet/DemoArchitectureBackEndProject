using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserOperationClaimsController : ControllerBase
    {
        IUserOperationClaimService userOperationClaimService;

        public UserOperationClaimsController(IUserOperationClaimService _userOperationClaimService)
        {
            userOperationClaimService = _userOperationClaimService;
        }
        [HttpPost("add")]
        public IActionResult Add(UserOperationClaim userOperationClaim)
        {
            userOperationClaimService.Add(userOperationClaim);
            return Ok();
        }
    }
}
