using FridaReads.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace FridaReads.Server.Repositories
{
    public class TextRepository
    {
        private readonly ApplicationDbContext _context;

        public TextRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Text> AddAsync(Text text)
        {
            _context.Text.Add(text);
            await _context.SaveChangesAsync();
            return text;
        }

        public async Task<Text> UpdateAsync(Text text)
        {
            _context.Text.Update(text);
            await _context.SaveChangesAsync();
            return text;
        }

        public async Task DeleteAsync(Text text)
        {
            _context.Text.Remove(text);
            await _context.SaveChangesAsync();
        }

        public async Task<Text> GetByIdAsync(int id)
        {
            return await _context.Text.FindAsync(id);
        }

        public async Task<List<Text>> GetByUserIdAsync(int userId)
        {
            return await _context.Text
                .Where(t => t.UserId == userId)
                .ToListAsync();
        }

        public virtual async Task<List<Text>> GetAllAsync()
        {
            return await _context.Text.ToListAsync();
        }
    }
}
