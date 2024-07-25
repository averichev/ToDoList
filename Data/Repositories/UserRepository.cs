using Data.Entities;
using Domain.Interfaces;

namespace Data.Repositories;

internal class UserRepository : IUserRepository
{
    private readonly TodoDbContext _context;

    public UserRepository(TodoDbContext context)
    {
        _context = context;
    }

    public async Task<IUserId> SaveUserAsync(IUserCreate userCreate)
    {
        var result = _context.Users.Add(User.Create(userCreate));
        await _context.SaveChangesAsync();
        return result.Entity.UserId();
    }
}