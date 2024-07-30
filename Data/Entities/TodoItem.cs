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

    internal static TodoItem Create(ITodoItemSave save)
    {
        return new TodoItem
        {
            Priority = (byte)save.Priority,
            Description = save.Description,
            Title = save.Title,
            UserId = int.Parse(save.UserId().Value())
        };
    }

    internal static TodoItem Create(ITodoItem item)
    {
        return new TodoItem
        {
            Priority = (byte)item.Priority(),
            Description = item.Description(),
            Title = item.Title(),
            UserId = int.Parse(item.UserId().Value())
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

    internal void Update(ITodoItemSave item)
    {
        Description = item.Description;
        Title = item.Title;
        Priority = (byte)item.Priority;
        DueDate = item.DueDate;
        UserId = Convert.ToInt32(item.UserId().Value());
    }

    internal void Update(ITodoItem item)
    {
        Description = item.Description();
        Title = item.Title();
        Priority = (byte)item.Priority();
        DueDate = item.DueDate();
        UserId = Convert.ToInt32(item.UserId().Value());
    }
}