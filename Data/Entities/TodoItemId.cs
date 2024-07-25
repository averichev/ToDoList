using Domain.Interfaces;

namespace Data.Entities;

internal class TodoItemId: ITodoItemId
{
    public string Value { get; internal set; }
}