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
        return new UserId
        {
            Value = Id.ToString()
        };
    }
}

internal class UserId : IUserId
{
    public string Value { get; internal set; }
}