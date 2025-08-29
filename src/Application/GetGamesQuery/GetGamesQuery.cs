using Application.Shared.GetGames;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.GetGamesQuery
{
    public sealed record GetGamesQuery(): IRequest<List<GetGamesResultModel>>;
}
