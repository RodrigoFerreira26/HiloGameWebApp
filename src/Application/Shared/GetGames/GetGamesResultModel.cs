using Domain.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Shared.GetGames
{
    public sealed record GetGamesResultModel(int NrTurns, int NrPlayers, long Id, List<History> Histories);
}
