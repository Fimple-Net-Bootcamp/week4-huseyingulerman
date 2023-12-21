using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using week4_huseyingulerman.Core.DTOs.Create;
using week4_huseyingulerman.Core.Entities;

namespace week4_huseyingulerman.Api.Controllers
{
    [Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly UserManager<AppUser> userManager;


    public UserController(UserManager<AppUser> _userManager)
    {
        this.userManager = _userManager;

    }
    // Kullanıcı İşlemleri
    [HttpPost]
    public async Task<IActionResult> Create(UserCreateDTO user)
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

    [HttpGet("{userid}")]
    public async Task<IActionResult> GetById(string userid)
    {
        var _user = await userManager.FindByIdAsync(userid);
        return Ok(_user);
    }
}
}
