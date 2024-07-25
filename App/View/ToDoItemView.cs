using Domain.Enums;
using Domain.Interfaces;

namespace App.View;

public class ToDoItemView
{
    private ToDoItemView(ITodoItem todoItem)
    {
        Id = todoItem.Id().Value();
        Title = todoItem.Title();
        Description = todoItem.Description();
        DueDate = todoItem.DueDate();
        Priority = todoItem.Priority();
        UserId = todoItem.UserId().Value();
    }

    internal static ToDoItemView New(ITodoItem todoItem)
    {
        return new ToDoItemView(todoItem);
    }

    public string Id { get; }
    public string Title { get; }
    public string Description { get; }
    public DateTime DueDate { get; }
    public Priority Priority { get; }
    public string UserId { get; set; }
}