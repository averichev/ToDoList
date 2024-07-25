using Domain.Interfaces;

namespace App.Dto;

public class TodoItemId: ITodoItemId
{
    public string Value { get; set; }
    string ITodoItemId.Value()
    {
        return Value;
    }
}