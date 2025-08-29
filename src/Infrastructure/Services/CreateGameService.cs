using Application.Shared.CreateGame;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    internal class CreateGameService : ICreateGameService
    {
        private readonly IGameRepository _gameRepository;
        public CreateGameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public async Task<Game> CreateGameAsync(CreateGameRequestModel requestModel)
        {
            Game game = new()
            {
                Histories = [requestModel.History],
                NrPlayers = 1
            };

            game = await _gameRepository.CreateGameAsync(game);

            return game;
        }
    }
}
