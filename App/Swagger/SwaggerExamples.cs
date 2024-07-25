using App.Dto;
using Domain.Enums;
using Swashbuckle.AspNetCore.Filters;

namespace App.Swagger;

public class SwaggerExamples : IExamplesProvider<TodoItemCreateDto>
{
    public TodoItemCreateDto GetExamples()
    {
        return new TodoItemCreateDto
        {
            Title = "Купить хлеб",
            Description = "Купить батон",
            DueDate = DateTime.Now,
            Priority = Priority.Low,
            UserId = new UserIdDto
            {
                Value = "user-id"
            }
        };
    }
}