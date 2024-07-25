using App.Dto;
using App.View;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using TodoItemId = App.Dto.TodoItemId;

namespace App.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ToDoItemsController : ControllerBase
{
    private readonly ITodoItemService _todoItemService;

    public ToDoItemsController(ITodoItemService todoItemService)
    {
        _todoItemService = todoItemService;
    }

    /// <summary>
    /// Создает новый элемент ToDo.
    /// </summary>
    /// <param name="todoItemCreateDto">DTO для создания элемента ToDo.</param>
    /// <returns>Идентификатор созданного элемента.</returns>
    [HttpPost]
    public async Task<IActionResult> CreateToDoItem([FromBody] TodoItemCreateDto todoItemCreateDto)
    {
        var newItemId = await _todoItemService.CreateTodoItemAsync(todoItemCreateDto);
        var result = ToDoItemIdView.New(newItemId);
        return Ok(result);
    }

    /// <summary>
    /// Читает задачу по Id  
    /// </summary>
    /// <param name="todoItemId">DTO для создания элемента ToDo.</param>
    /// <returns>Идентификатор созданного элемента.</returns>
    [HttpPost]
    public async Task<IActionResult> ReadToDoItem([FromBody] TodoItemId todoItemId)
    {
        var exist = await _todoItemService.ReadTodoItemAsync(todoItemId);
        var m = exist.Match<IActionResult>(
            some: x => Ok(ToDoItemView.New(x)),
            none: () => NotFound("Задача не найдена")
        );
        return m;
    }
}