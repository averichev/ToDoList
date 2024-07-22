using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;

namespace App.Dto;

public class UserIdDto: IUserId
{
    public UserIdDto()
    {
    }

    [Required]
    public string Value { get; set; }
}