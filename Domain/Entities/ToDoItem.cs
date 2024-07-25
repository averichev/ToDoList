using Domain.Enums;
using Domain.Interfaces;

namespace Domain.Entities;

public class ToDoItem : ITodoItem
{
    public ITodoItemId Id()
    {
        throw new NotImplementedException();
    }

    public string Title()
    {
        throw new NotImplementedException();
    }

    public string Description()
    {
        throw new NotImplementedException();
    }

    public DateTime DueDate()
    {
        throw new NotImplementedException();
    }

    public Priority Priority()
    {
        throw new NotImplementedException();
    }

    public IUserId UserId()
    {
        throw new NotImplementedException();
    }
}