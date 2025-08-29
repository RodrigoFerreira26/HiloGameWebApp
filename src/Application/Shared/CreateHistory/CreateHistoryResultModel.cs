using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Shared.CreateHistory
{
    public sealed record CreateHistoryResultModel(int Number, int Turn, int MysteryNumber, long GameId);
}
