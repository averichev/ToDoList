using Data.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Optional;

namespace Data.Repositories;

internal class TodoItemRepository : ITodoItemRepository
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

    public async Task<Option<ITodoItem>> ReadTodoItemAsync(ITodoItemId todoItemId)
    {
        var item = await _context.TodoItems
            .FirstOrDefaultAsync();
        return item != null ? Option.Some<ITodoItem>(item) : Option.None<ITodoItem>();
    }
}