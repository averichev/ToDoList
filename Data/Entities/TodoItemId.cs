using Domain.Interfaces;

namespace Data.Entities;

internal class TodoItemId : ITodoItemId
{
    private readonly string _value;

    private TodoItemId(string value)
    {
        _value = value;
    }

    public static ITodoItemId New(string value)
    {
        return new TodoItemId(value);
    }
    public static ITodoItemId New(int value)
    {
        return new TodoItemId(value.ToString());
    }

    public string Value()
    {
        return _value;
    }
}