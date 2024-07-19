using System.ComponentModel.DataAnnotations;
using Domain.Enums;
using Domain.Interfaces;
using Swashbuckle.AspNetCore.Filters;

namespace App.Dto;

public class ToDoItemCreateDto : IToDoItemCreate, IExamplesProvider<ToDoItemCreateDto>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public Priority Priority { get; set; }

    [Required]
    public UserIdDto UserId { get; set; }

    IUserId IToDoItemCreate.UserId()
    {
        return UserId;
    }

    public ToDoItemCreateDto GetExamples()
    {
        return new ToDoItemCreateDto
        {
            Title = "Купить хлеб",
            Description = "Купить батон",
            DueDate = DateTime.Now,
            Priority = Priority.Low,
            UserId = new UserIdDto{}
        };
    }
}