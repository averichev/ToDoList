using Domain.Enums;
using Domain.Interfaces;

namespace App.Dto;

public class ToDoItemCreateDto: IToDoItemCreate
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public Priority Priority { get; set; }
    public IUserId UserId { get; set; }
}