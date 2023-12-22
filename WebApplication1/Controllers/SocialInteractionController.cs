using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using week4_huseyingulerman.Core.Services;
using week4_huseyingulerman.Service.Services;

namespace week4_huseyingulerman.Api.Controllers
{
    [Route("api/socialinteractions")]
    [ApiController]
    public class SocialInteractionController : ControllerBase
    {
        private readonly IPetSocialInteractionService _petSocialInteractionService;
        public SocialInteractionController(IPetSocialInteractionService petSocialInteractionService)
        {
            _petSocialInteractionService=petSocialInteractionService;
        }
        [HttpGet("{petid}")]
        public async Task<IActionResult> GetByPetId(int petid)
        {
            var appResult = await _petSocialInteractionService.GetPetSocialInteractionByPetId(petid);

            return Ok(appResult.Data);
        }

        [HttpPost("{petid}")]
        public async Task<IActionResult> Create(int petid, int socialInteractionid)
        {
            var appResult = await _petSocialInteractionService.AddSocialInteractionByPetId(petid, socialInteractionid);
            return StatusCode(appResult.StatusCode);
        }
    }
}
