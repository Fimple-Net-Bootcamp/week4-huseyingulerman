using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using week4_huseyingulerman.Core.DTOs.Create;
using week4_huseyingulerman.Core.Entities;
using week4_huseyingulerman.Core.Services;

namespace week4_huseyingulerman.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IPetService _petservice;

        public UserController(UserManager<AppUser> _userManager, IPetService petService)
        {
            this.userManager = _userManager;
            _petservice=petService;

        }
        // Kullanıcı İşlemleri
        [HttpPost]
        public async Task<IActionResult> Create(UserCreateDTO user)
        {
            if (ModelState.IsValid)
            {


                AppUser appuser = new AppUser()
                {
                    FİrstName=user.FirstName,
                    LastName=user.LastName,
                    UserName = user.UserName,
                    IsActive=user.IsActive,
                    Email = user.Email,
                };
          
            IdentityResult result = await userManager.CreateAsync(appuser);
           
            return CreatedAtAction(nameof(GetById), new { userid = appuser.Id }, appuser);
            }
            return BadRequest();
        }

        [HttpGet("{userid}")]
        public async Task<IActionResult> GetById(string userid)
        {
            var _user = await userManager.FindByIdAsync(userid);
            return Ok(_user);
        }

        [HttpGet("statistics/{userid}")]
        public async Task<IActionResult> GetAllUser(string userid)
        {
            var _user = await _petservice.GetUserStatisticsByUserId(userid);
            return Ok(_user.Data);
        }
    }
}
