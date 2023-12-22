using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using week4_huseyingulerman.Core.DTOs.Create;
using week4_huseyingulerman.Core.DTOs.Update;
using week4_huseyingulerman.Core.Services;

namespace week4_huseyingulerman.Api.Controllers
{
    [Route("api/pets")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetService _petservice;
        public PetController(IPetService petService)
        {
            _petservice=petService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var appResultPets = await _petservice.GetAllActiveAsync();
            return Ok(appResultPets.Data);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var appResultPet = await _petservice.GetByIdAsync(id);
            return Ok(appResultPet.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PetCreateDTO pet)
        {
            var appResultPet = await _petservice.AddAsync(pet);
            return CreatedAtAction(nameof(GetById), new { id = appResultPet.Data.Id }, appResultPet);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, PetUpdateDTO pet)
        {
            var appResultPet = await _petservice.UpdatePetAsync(id, pet);

            return Ok(appResultPet.StatusCode);
        }


        //---------------------------------------------------

        [HttpGet("statistics/{petid}")]
        public async Task<IActionResult> GetAllPetStatisticByPetId(int petid)
        {
            var appResultPet = await _petservice.GetAllPetStatisticByPetId(petid);
            return Ok(appResultPet.Data);
        }
    }
}
