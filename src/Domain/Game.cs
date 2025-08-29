using Domain.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Game
    {
        public long Id { get; set; }

        public int NrPlayers { get; set; }

        public List<Domain.History.History> Histories { get; set; }
    }
}
