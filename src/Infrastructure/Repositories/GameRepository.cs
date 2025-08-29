using Domain;
using Domain.History;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class GameRepository : IGameRepository
    {
        private readonly ApplicationDbContext _context;

        public GameRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Game> CreateGameAsync(Game game)
        {
            _context.Add(game);
            await _context.SaveChangesAsync();
            return game;
        }

        public async Task<List<Game>> GetGamesAsync()
        {
            return await _context.Game.Include(x => x.Histories).ToListAsync();
        }

        public async Task<Game> GetGameByIdAsync(long id)
        {
            return await _context.Game.Include(x => x.Histories).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
