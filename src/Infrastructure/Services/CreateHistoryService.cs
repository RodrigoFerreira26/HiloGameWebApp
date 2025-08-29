using Application.Shared.CreateHistory;
using Domain.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    internal class CreateHistoryService : ICreateHistoryService
    {
        private readonly IHistoryRepository _historyRepository;

        public CreateHistoryService(IHistoryRepository historyRepository)
        {
            _historyRepository = historyRepository;
        }

        public async Task CreateHistoryAsync(CreateHistoryResultModel requestModel)
        {
            History history = new()
            {
                Turn = requestModel.Turn,
                DatePlayed = DateTime.Now,
                GuessedNumber = requestModel.Number,
                MysteryNumber = requestModel.MysteryNumber,
                GameId = requestModel.GameId
            };

            await _historyRepository.CreateHistoryAsync(history);


        }
    }
}
