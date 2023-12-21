using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using week4_huseyingulerman.Core.DTOs.Create;
using week4_huseyingulerman.Core.Services;

namespace week4_huseyingulerman.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService _activityService;
        public ActivityController(IActivityService activityService)
        {
            _activityService=activityService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ActivityCreateDTO activity)
        {
            var appResultPet = await _activityService.AddActivityByPetId(activity);
            return StatusCode(201);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var appResultActivity = await _activityService.GetActivityByPetId(id);
            return Ok(appResultActivity);

        }
    }
}
