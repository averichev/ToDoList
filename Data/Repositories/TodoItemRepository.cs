using Data.Entities;
using Domain.Interfaces;

namespace Data.Repositories;

public class TodoItemRepository: ITodoItemRepository
{
    private readonly TodoDbContext _context;

    public TodoItemRepository(TodoDbContext context)
    {
        _context = context;
    }
    public async Task<ITodoItemId> CreateTodoItemAsync(ITodoItemCreate item)
    {
        var create = TodoItem.Create(item);
        _context.TodoItems.Add(create);
        await _context.SaveChangesAsync();
        return create.TodoItemId();
    }
}