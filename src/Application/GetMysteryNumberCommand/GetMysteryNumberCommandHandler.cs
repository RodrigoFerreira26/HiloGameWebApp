using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.GetMysteryNumberCommand
{
    public class GetMysteryNumberCommandHandler : IRequestHandler<GetMysteryNumberCommand, int>
    {
        public GetMysteryNumberCommandHandler()
        {
        }

        public Task<int> Handle(GetMysteryNumberCommand request, CancellationToken cancellationToken)
        {
            Random random = new();

            return Task.FromResult(random.Next(1, 1001));
        }
    }
}
