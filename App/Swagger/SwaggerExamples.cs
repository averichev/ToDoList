using App.Dto;
using Domain.Enums;
using Swashbuckle.AspNetCore.Filters;

namespace App.Swagger;

public class SwaggerExamples : IExamplesProvider<TodoItemDto>
{
    public TodoItemDto GetExamples()
    {
        return new TodoItemDto
        {
            Title = "Купить хлеб",
            Description = "Купить батон",
            DueDate = DateTime.Now,
            Priority = Priority.Low
        };
    }
}