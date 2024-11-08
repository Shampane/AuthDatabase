using AuthDatabase.Authentication.Contracts;
using AuthDatabase.Authentication.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthDatabase.Authentication.Controllers;

[ApiController]
[Route("account")]
public class AccountsController : ControllerBase
{
    public AccountsController(UserManager<UserEntity> userManager, IMapper mapper)
    {
        _userManager = userManager;
        _mapper = mapper;
    }

    private readonly UserManager<UserEntity> _userManager;
    private readonly IMapper _mapper;

    [HttpPost("register")]
    public async Task<IActionResult> RegisterUser(
        [FromBody] UserRegistrationDto userRegistrationDto
    )
    {
        if (userRegistrationDto == null)
            return BadRequest();

        var user = _mapper.Map<UserEntity>(userRegistrationDto);
        var result = await _userManager.CreateAsync(
            user,
            userRegistrationDto.Password
        );

        if (!result.Succeeded)
        {
            var errors = result.Errors.Select(e => e.Description);
            return BadRequest(new ResponseRegistrationDto { Errors = errors });
        }

        return Ok();
    }
}
