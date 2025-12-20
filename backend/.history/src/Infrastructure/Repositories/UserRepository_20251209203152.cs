using backend.Src.Domain.Entities;
using backend.Src.Domain.Interfaces;
using backend.Src.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace backend.Src.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<User?> GetByIdAsync(Guid id)
        => await _context.Users.FirstOrDefaultAsync(u => u.Id == id);

    public async Task<User?> GetByEmailAsync(string email)
        => await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

    public async Task AddAsync(User user)
        => await _context.Users.AddAsync(user);
}
