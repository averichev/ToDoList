using Domain.Enums;
using Domain.Interfaces;

namespace App.View;

public class ToDoItemView
{
    private ToDoItemView(ITodoItem todoItem)
    {
        Id = todoItem.Id();
        Title = todoItem.Title();
        Description = todoItem.Description();
        DueDate = todoItem.DueDate();
        Priority = todoItem.Priority();
    }

    internal static ToDoItemView New(ITodoItem todoItem)
    {
        return new ToDoItemView(todoItem);
    }

    public ITodoItemId Id { get; }
    public string Title { get; }
    public string Description { get; }
    public DateTime DueDate { get; }
    public Priority Priority { get; }
}