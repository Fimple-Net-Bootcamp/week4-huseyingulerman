using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using week4_huseyingulerman.Core.DTOs.Create;
using week4_huseyingulerman.Core.Entities;
using week4_huseyingulerman.Core.Services;

namespace week4_huseyingulerman.Api.Controllers
{
    [Route("api/foods")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _foodService;
        private readonly IFoodPetService _foodPetService;

        public FoodController(IFoodService foodService, IFoodPetService foodPetService)
        {
            _foodService=foodService;
            _foodPetService=foodPetService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var appResultFoods = await _foodService.GetAllActiveAsync();
            return Ok(appResultFoods);

        }

        [HttpPost("{petid}")]
        public async Task<IActionResult> Create(int petid, int foodid)
        {
                var appResultFood = await _foodPetService.AddFoodByPetId(petid, foodid);


            return CreatedAtAction(nameof(GetById), new { foodpetid = appResultFood.Data.Id}, appResultFood);

        }
        [HttpGet("{foodpetid}")]
        public async Task<IActionResult> GetById(int foodpetid)
        {
            var foodpet = await _foodPetService.GetByIdAsync(foodpetid);
            return Ok(foodpet);
        }
    }
}
