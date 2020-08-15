using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreePortSoccer.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        public string Abbreviation { get; set; }
        public string PositionDes { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
