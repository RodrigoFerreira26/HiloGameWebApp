using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Shared.CreateGame
{
    public interface ICreateGameService
    {
        Task<Game> CreateGameAsync(CreateGameRequestModel requestModel);
    }
}
