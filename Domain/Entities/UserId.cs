using Domain.Interfaces;

namespace Domain.Entities;

public class UserId : IUserId
{
    private readonly string _value;
    private UserId(string value)
    {
        _value = value;
    }

    public static IUserId New(string value)
    {
        return new UserId(value);
    }
    
    public static IUserId New(int value)
    {
        return new UserId(value.ToString());
    }

    public string Value()
    {
        return _value;
    }
}