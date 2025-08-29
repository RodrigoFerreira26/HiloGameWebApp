using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.History
{
    public interface IHistoryRepository
    {
        Task<IEnumerable<History>> GetHistoryByIdAsync(long id);

        Task CreateHistoryAsync(History history);
    }
}
