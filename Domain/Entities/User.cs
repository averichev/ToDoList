using Domain.Interfaces;

namespace Domain.Entities;

public class User : IUser
{
    private User(string username, IUserId id)
    {
        Username = username;
        Id = id;
    }

    public static IUser New(string username, IUserId id)
    {
        return new User(username, id);
    }

    public IUserId Id { get; }
    public string Username { get; }
}