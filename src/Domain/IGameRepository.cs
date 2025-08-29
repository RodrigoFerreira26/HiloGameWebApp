using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IGameRepository
    {
        Task<Game> CreateGameAsync(Game game);

        Task<List<Game>> GetGamesAsync();

        Task<Game> GetGameByIdAsync(long id);
    }
}
