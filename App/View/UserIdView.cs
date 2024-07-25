using Domain.Interfaces;

namespace App.View;

public class UserIdView
{
    private UserIdView(string value)
    {
        Value = value;
    }

    public static UserIdView New(IUserId userId)
    {
        return new UserIdView(userId.Value);
    }

    public string Value { get; private set; }
}