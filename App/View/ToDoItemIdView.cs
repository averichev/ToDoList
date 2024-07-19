using Domain.Interfaces;

namespace App.View;

internal class ToDoItemIdView
{
    private ToDoItemIdView(IToDoItemId toDoItemId)
    {
        Value = toDoItemId.Value;
    }

    internal static ToDoItemIdView New(IToDoItemId toDoItemId)
    {
        return new ToDoItemIdView(toDoItemId);
    }

    string Value { get; }
}