using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Interfaces;

namespace Data.Entities;

[Table("User")]
public class User
{
    [Key]
    public int Id { get; set; }

    public string Username { get; set; }

    internal static User Create(IUserCreate userCreate)
    {
        return new User
        {
            Username = userCreate.Username
        };
    }

    internal IUserId UserId()
    {
        return Entities.UserId.New(Id);
    }
}

internal class UserId : IUserId
{
    private string _value;

    private UserId(string value)
    {
        _value = value;
    }

    internal static IUserId New(int value)
    {
        return new UserId(value.ToString());
    }

    string IUserId.Value()
    {
        return _value;
    }
}