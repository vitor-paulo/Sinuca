using Microsoft.AspNetCore.Mvc;
using Sinuca.Application.Models;
using Sinuca.Application.Services;

namespace Sinuca.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : Controller
    {
        private readonly IMatchService _matchService;

        public MatchController(IMatchService matchService)
        {
            _matchService = matchService;
        }

        [HttpPost]
        [Route("initialize")]
        public async Task<IActionResult> Initialize([FromBody] MatchInitializeRequest request)
        {
            await _matchService.InitializeMatch(request);
            return Ok();
        }

        [HttpPost]
        [Route("close")]
        public async Task<IActionResult> Close([FromBody] MatchCloseRequest request)
        {
            await _matchService.CloseMatch(request);
            return Ok();
        }
    }
}