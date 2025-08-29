using Application.Shared.GetHistory;
using Domain.History;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.GetPlayHistory
{
    public sealed record GetPlayHistoryQuery(long Id) : IRequest<List<GetHistoryResultModel>>;
}
