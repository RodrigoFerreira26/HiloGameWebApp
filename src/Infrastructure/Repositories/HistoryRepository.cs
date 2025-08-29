using Domain.History;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class HistoryRepository : Domain.History.IHistoryRepository
    {
        private readonly ApplicationDbContext _context;
        public HistoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateHistoryAsync(History history)
        {
            _context.Add(history);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<History>> GetHistoryByIdAsync(long id)
        {
            return await _context.History.Where(x => x.GameId == id).ToListAsync();
        }
    }
}
