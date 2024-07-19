using Domain.Enums;

namespace Domain.Entities;

internal class ToDoItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime DueDate { get; set; }
    public Priority Priority { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}