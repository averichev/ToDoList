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
    public string Description { get; set; } = "";
    public Priority Priority { get; set; }

    internal static TodoItem Create(ITodoItemCreate create)
    {
        return new TodoItem
        {
            Priority = create.Priority,
            Description = create.Description,
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