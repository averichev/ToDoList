using App.Dto;
using App.View;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ToDoItemsController : ControllerBase
{
    private readonly IToDoItemService _toDoItemService;

    public ToDoItemsController(IToDoItemService toDoItemService)
    {
        _toDoItemService = toDoItemService;
    }

    /// <summary>
    /// Создает новый элемент ToDo.
    /// </summary>
    /// <param name="toDoItemCreateDto">DTO для создания элемента ToDo.</param>
    /// <returns>Идентификатор созданного элемента.</returns>
    [HttpPost]
    public async Task<IActionResult> CreateToDoItem([FromBody] ToDoItemCreateDto toDoItemCreateDto)
    {
        var newItemId = await _toDoItemService.CreateToDoItemAsync(toDoItemCreateDto);
        var result = ToDoItemIdView.New(newItemId);
        return Ok(result);
    }
}