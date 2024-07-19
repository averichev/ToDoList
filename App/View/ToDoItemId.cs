using Domain.Interfaces;

namespace App.View;

internal class ToDoItemId
{
    private ToDoItemId(IToDoItemId toDoItemId)
    {
        Value = toDoItemId.Value;
    }

    internal static ToDoItemId New(IToDoItemId toDoItemId)
    {
        return new ToDoItemId(toDoItemId);
    }

    string Value { get; }
}