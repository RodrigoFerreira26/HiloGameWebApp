using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Shared.CreateHistory
{
    public interface ICreateHistoryService
    {
        Task CreateHistoryAsync(CreateHistoryResultModel requestModel);
    }
}
