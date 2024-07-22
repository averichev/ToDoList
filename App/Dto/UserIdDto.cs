using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;

namespace App.Dto;

public class UserIdDto: IUserId
{
    [Required]
    public string Value { get; }

    private UserIdDto(string value)
    {
        Value = value;
    }

    internal static UserIdDto New(string value)
    {
        return new UserIdDto(value);
    }
}