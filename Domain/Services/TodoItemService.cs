using Domain.Interfaces;

namespace Domain.Services;

internal class TodoItemService : ITodoItemService
{
    private readonly ITodoItemRepository _repository;
    public TodoItemService(ITodoItemRepository repository)
    {
        _repository = repository;
    }
    public async Task<ITodoItemId> CreateTodoItemAsync(ITodoItemCreate item)
    {
        var id = await _repository.CreateTodoItemAsync(item);
        return id;
    }
}