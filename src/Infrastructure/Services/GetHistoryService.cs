using Application.Shared.GetHistory;
using Domain.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    internal class GetHistoryService : IGetHistoryService
    {
        private readonly IHistoryRepository repository;
        public GetHistoryService(IHistoryRepository repository)
        {
            this.repository = repository;
        }

        public async Task<List<GetHistoryResultModel>> GetHistoriesAsync(long id)
        {
            IEnumerable<History> histories = await repository.GetHistoryByIdAsync(id);

            return histories.ToList().ConvertAll(x => new GetHistoryResultModel(x.GameId, x.GuessedNumber, x.MysteryNumber, x.Turn, x.DatePlayed));
        }
    }
}
