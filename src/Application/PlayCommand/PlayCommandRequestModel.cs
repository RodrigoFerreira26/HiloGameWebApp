using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PlayCommand
{
    public class PlayCommandResponse
    {
        public string HiLo { get; set; }

        public bool IsCorrect { get; set; }

        public long GameId { get; set; }
    }
}
