using App.Dto;
using Domain.Enums;
using Swashbuckle.AspNetCore.Filters;

namespace App.Swagger;

public class SwaggerExamples : IExamplesProvider<ToDoItemCreateDto>
{
    public ToDoItemCreateDto GetExamples()
    {
        return new ToDoItemCreateDto
        {
            Title = "Купить хлеб",
            Description = "Купить батон",
            DueDate = DateTime.Now,
            Priority = Priority.Low,
            UserId = UserIdDto.New("user-id")
        };
    }
}