using Data.Entities;
using Domain.Interfaces;
using LanguageExt;
using LanguageExt.Common;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

internal class TodoItemRepository : ITodoItemRepository
{
    private readonly TodoDbContext _context;

    public TodoItemRepository(TodoDbContext context)
    {
        _context = context;
    }

    public async Task<ITodoItemId> CreateTodoItemAsync(ITodoItemSave item)
    {
        var create = TodoItem.Create(item);
        _context.TodoItems.Add(create);
        await _context.SaveChangesAsync();
        return create.TodoItemId();
    }

    private async Task<Option<TodoItem>> ReadRecordAsync(ITodoItemId id)
    {
        var item = await _context.TodoItems
            .FirstOrDefaultAsync(n => n.Id.Equals(int.Parse(id.Value())));
        return item != null ? Option<TodoItem>.Some(item) : Option<TodoItem>.None;
    }


    public async Task<Option<ITodoItem>> ReadTodoItemAsync(ITodoItemId id)
    {
        var item = await ReadRecordAsync(id);
        return item.Match(
            Some: Option<ITodoItem>.Some,
            None: () => Option<ITodoItem>.None
        );
    }

    private async void UpdateRecordAsync(TodoItem i, ITodoItem item)
    {
        i.Update(item);
        await _context.SaveChangesAsync();
    }

    private async Task UpdateExistRecordAsync(ITodoItem item)
    {
        var exist = await ReadRecordAsync(item.Id());
        await exist.IfSomeAsync(i => UpdateRecordAsync(i, item));
    }

    public async Task<Result<DateTime>> UpdateTodoItemAsync(ITodoItem item)
    {
        try
        {
            await UpdateExistRecordAsync(item);
        }
        catch (Exception e)
        {
            return new Result<DateTime>(e);
        }

        return new Result<DateTime>(DateTime.Now);
    }
}