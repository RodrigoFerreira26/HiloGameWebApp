using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Shared.GetGames
{
    public interface IGetGamesService
    {
        Task<List<GetGamesResultModel>> GetGamesAsync();
    }
}
