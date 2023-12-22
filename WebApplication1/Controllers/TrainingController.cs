using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using week4_huseyingulerman.Core.Services;
using week4_huseyingulerman.Service.Services;

namespace week4_huseyingulerman.Api.Controllers
{
    [Route("api/trainings")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingService _trainingService;
        private readonly IPetTrainingService _petTrainingService;
        public TrainingController(ITrainingService trainingService, IPetTrainingService petTrainingService)
        {
            _trainingService=trainingService;
            _petTrainingService=petTrainingService;
        }
        [HttpGet("{petid}")]
        public async Task<IActionResult> GetByPetId(int petid)
        {
            var appResult=await _petTrainingService.GetPetTrainingByPetId(petid);

            return Ok(appResult.Data);
        }

        [HttpPost("{petid}")]
        public async Task<IActionResult> Create(int petid, int trainingid)
        {
            var appResultPetTraining = await _petTrainingService.AddTrainingByPetId(petid, trainingid);


            return StatusCode(appResultPetTraining.StatusCode);
            //return CreatedAtAction(nameof(GetByPetId), new { petid = appResultPetTraining.Data.PetId }, appResultPetTraining);

        }
    }
}
