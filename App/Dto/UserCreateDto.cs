using System.ComponentModel.DataAnnotations;
using Domain.Interfaces;

namespace App.Dto;

public class UserCreateDto: IUserCreate
{
    [Required]
    public string Username { get; set; }
}