using Domain.Enums;

namespace Domain.Interfaces;

public interface IToDoItemCreate
{
    public string Title { get; }
    public string Description { get; }
    public DateTime DueDate { get; }
    public Priority Priority { get; }
    public IUserId UserId();
}