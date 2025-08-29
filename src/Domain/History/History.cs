using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.History
{
    public class History
    {
        public long Id { get; set; }

        public long GameId { get; set; }

        public int MysteryNumber { get; set; }

        public int GuessedNumber { get; set; }

        public int Turn { get; set; }

        public DateTime DatePlayed { get; set; } 
    }
}
