using App.Dto;
using App.View;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    /// <summary>
    /// Создает нового пользователя
    /// </summary>
    /// <param name="userCreateDto">DTO для создания пользователя.</param>
    /// <returns>Идентификатор созданного пользователя.</returns>
    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] UserCreateDto userCreateDto)
    {
        var newUserId = await _userService.CreateUserAsync(userCreateDto);
        var result = UserIdView.New(newUserId);
        return Ok(result);
    }
}