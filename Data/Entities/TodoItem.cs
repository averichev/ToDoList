using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums;
using Domain.Interfaces;

namespace Data.Entities;

[Table("TodoItem")]
internal class TodoItem
{
    [Key]
    public int Id { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }
    public byte Priority { get; set; }

    public User User { get; set; }
    public int UserId { get; set; }

    internal static TodoItem Create(ITodoItemCreate create)
    {
        return new TodoItem
        {
            Priority = (byte)create.Priority,
            Description = create.Description,
            Title = create.Title
        };
    }

    internal ITodoItemId TodoItemId()
    {
        return new TodoItemId
        {
            Value = Id.ToString()
        };
    }
}