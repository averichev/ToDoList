using Domain.Interfaces;

namespace App.View;

internal class ToDoItemIdView
{
    private ToDoItemIdView(ITodoItemId todoItemId)
    {
        Value = todoItemId.Value;
    }

    internal static ToDoItemIdView New(ITodoItemId todoItemId)
    {
        return new ToDoItemIdView(todoItemId);
    }

    public string Value { get; }
}