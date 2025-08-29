using Domain.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Shared.CreateGame
{
    public sealed record CreateGameRequestModel(History History);
}
