using Domain.Enums;

namespace Domain.Interfaces;

public interface ITodoItem
{
    public ITodoItemId Id();
    public string Title();
    public string Description();
    public DateTime DueDate();
    public Priority Priority();
    public IUserId UserId();
}