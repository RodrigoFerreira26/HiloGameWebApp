using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Shared.GetHistory
{
    public sealed record GetHistoryResultModel(long GameId, int GuessedNumber, int MysteryNumber, int Turn, DateTime Date);
}
