using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using week4_huseyingulerman.Core.DTOs;
using week4_huseyingulerman.Core.DTOs.Update;
using week4_huseyingulerman.Core.Entities;
using week4_huseyingulerman.Core.Services;

namespace week4_huseyingulerman.Api.Controllers
{
    [Route("api/healths")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        private readonly IHealthService _healthService;
        private readonly IMapper _mapper;
        public HealthController(IHealthService healthService, IMapper mapper)
        {
            _healthService=healthService;
            _mapper=mapper;
        }
        [HttpGet("{petid}")]
        public async Task<IActionResult> GetById(int petid)
        {
            var appResultHealth = await _healthService.GetHealtyByPetId(petid);
            return Ok(appResultHealth);

        }
        [HttpPatch("{petid}")]
        public async Task<IActionResult> UpdateHealthById(int petid, string Situation)
        {
            var appResultHealth = await _healthService.GetHealtyByPetId(petid);
            appResultHealth.Situation = Situation;
            var a = _mapper.Map<HealthUpdateDTO>(appResultHealth);
           var ab= await _healthService.UpdateAsync(a);
       

            return CreatedAtAction(nameof(GetById), new {petid= a}, a);
        }
    }
}
