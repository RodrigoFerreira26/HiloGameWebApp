using Application.Shared.GetGames;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    internal class GetGamesService : IGetGamesService
    {
        private readonly IGameRepository _gameRepository;

        public GetGamesService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public async Task<List<GetGamesResultModel>> GetGamesAsync() { 
            List<Game> games = await _gameRepository.GetGamesAsync();

            return games.ConvertAll(x => new GetGamesResultModel(
                x.Histories.Count, 1, x.Id, x.Histories));
        }
    }
}
