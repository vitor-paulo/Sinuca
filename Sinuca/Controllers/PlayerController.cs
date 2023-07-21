using Microsoft.AspNetCore.Mvc;
using Sinuca.Application.Models;
using Sinuca.Application.Services;

namespace Sinuca.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : Controller
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PlayerRequest request)
        {
            await _playerService.Create(request);
            return Ok();
        }
    }
}
