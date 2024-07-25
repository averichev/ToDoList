using System.ComponentModel.DataAnnotations;
using Domain.Enums;
using Domain.Interfaces;

namespace App.Dto;

public class TodoItemCreateDto : ITodoItemCreate
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public Priority Priority { get; set; }

    IUserId ITodoItemCreate.UserId()
    {
        return Domain.Entities.UserId.New(UserId);
    }

    [Required]
    public string UserId { get; set; }
}