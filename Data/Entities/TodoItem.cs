using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums;
using Domain.Interfaces;

namespace Data.Entities;

[Table("TodoItem")]
internal class TodoItem : ITodoItem
{
    [Key]
    public int Id { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }
    public byte Priority { get; set; }

    public User User { get; set; }
    public int UserId { get; set; }

    public DateTime DueDate { get; set; }

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
        return Entities.TodoItemId.New(Id);
    }

    ITodoItemId ITodoItem.Id()
    {
        return Domain.Entities.TodoItemId.FromInt(Id);
    }

    string ITodoItem.Title()
    {
        return Title;
    }

    string ITodoItem.Description()
    {
        return Description;
    }

    DateTime ITodoItem.DueDate()
    {
        return DueDate;
    }

    Priority ITodoItem.Priority()
    {
        return (Priority)Priority;
    }

    IUserId ITodoItem.UserId()
    {
        return Domain.Entities.UserId.New(UserId);
    }
}