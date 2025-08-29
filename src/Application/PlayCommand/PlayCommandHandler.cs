using Application.Shared.CreateGame;
using Application.Shared.CreateHistory;
using Cqrs.Commands;
using Domain;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PlayCommand
{
    public class PlayCommandHandler : IRequestHandler<PlayCommand, PlayCommandResponse>
    {
        private readonly ICreateGameService _gameService;
        private readonly ICreateHistoryService _historyService;
        private readonly IGameRepository _gameRepository;

        public PlayCommandHandler(ICreateGameService gameService, ICreateHistoryService historyService, IGameRepository gameRepository)
        {
            _gameService = gameService;
            _historyService = historyService;
            _gameRepository = gameRepository;
        }

        /// <summary>
        /// Handler
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<PlayCommandResponse> Handle(PlayCommand command, CancellationToken cancellationToken)
        {
            Game game;
            if (command.FirstTurn)
            {
                game = await _gameService.CreateGameAsync(
                    new CreateGameRequestModel(
                        new Domain.History.History {
                            DatePlayed = DateTime.Now,
                            GuessedNumber = command.Number,
                            MysteryNumber = command.MysteryNumber,
                            Turn = 1}));
            }
            else
            {
                game = await _gameRepository.GetGameByIdAsync((long)command.GameId);

                if(game is null)
                {
                    throw new ValidationException("Game doesn't exist");
                }

                await _historyService.CreateHistoryAsync(new CreateHistoryResultModel(command.Number, game.Histories.Count + 1, command.MysteryNumber, game.Id));
            }


            if (command.Number == command.MysteryNumber)
            {
                return new PlayCommandResponse
                {
                    HiLo = "Correct",
                    IsCorrect = true,
                    GameId = game.Id
                };
            }
            else
            {
                return new PlayCommandResponse
                {
                    HiLo = command.MysteryNumber > command.Number ? "HI" : "LO",
                    IsCorrect = false,
                    GameId = game.Id
                };
            }
        }
    }
}
