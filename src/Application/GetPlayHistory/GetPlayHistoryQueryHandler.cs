using Application.Shared.GetHistory;
using Domain.History;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.GetPlayHistory
{
    public class GetPlayHistoryQueryHandler : IRequestHandler<GetPlayHistoryQuery, List<GetHistoryResultModel>>
    {
        private readonly IGetHistoryService _getHistoryService;

        public GetPlayHistoryQueryHandler(IGetHistoryService getHistoryService)
        {
            _getHistoryService = getHistoryService;
        }

        public async Task<List<GetHistoryResultModel>> Handle(GetPlayHistoryQuery request, CancellationToken cancellationToken)
        {
            List<GetHistoryResultModel> histories = await _getHistoryService.GetHistoriesAsync(request.Id);

            if(histories is null || histories?.Count == 0)
            {
                throw new ValidationException("History for that game doesn't exist");
            }

            return histories;
        }
    }
}
