using Application.Shared.GetGames;
using Domain;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.GetGamesQuery
{
    public class GetGamesQueryHandler : IRequestHandler<GetGamesQuery, List<GetGamesResultModel>>
    {
        private readonly IGetGamesService getGamesService;

        public GetGamesQueryHandler(IGetGamesService getGamesService)
        {
            this.getGamesService = getGamesService;
        }

        public async Task<List<GetGamesResultModel>> Handle(GetGamesQuery request, CancellationToken cancellationToken)
        {
            List<GetGamesResultModel> gameHistory = await getGamesService.GetGamesAsync();

            if (gameHistory is null || gameHistory?.Count == 0)
            {
                throw new ValidationException("Game history doesn't exist");
            }

            return gameHistory;
        }
    }
}
