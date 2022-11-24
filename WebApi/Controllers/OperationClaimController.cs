using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationClaimController : ControllerBase
    {
        IOperationClaimService _operationClaimService;
        public OperationClaimController(IOperationClaimService operationClaimService)
        {
            _operationClaimService = operationClaimService;
        }
        [HttpPost("add")]
        public IActionResult Add(OperationClaim operationClaim)
        {
            _operationClaimService.Add(operationClaim);
            return Ok();    
        }
    }
}
