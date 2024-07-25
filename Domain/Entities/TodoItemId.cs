using Domain.Interfaces;

namespace Domain.Entities;

public class TodoItemId: ITodoItemId
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
    
    public static ITodoItemId FromInt(int value)
    {
        return new TodoItemId(value.ToString());
    }

    public string Value()
    {
        return _value;
    }
}