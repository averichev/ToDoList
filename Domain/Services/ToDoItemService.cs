using Domain.Interfaces;

namespace Domain.Services;

internal class ToDoItemService : IToDoItemService
{
    public Task<IToDoItemId> CreateToDoItemAsync(IToDoItemCreate item)
    {
        throw new NotImplementedException();
    }
}