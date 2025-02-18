using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScape.Data
{
    internal class MagicStat
    {
        public int Id { get; set; }
        public int StatId { get; set; }
        public int MagicId { get; set; }
        public int Value { get; set; }
        public Stat Stat { get; set; }
        public Magic Magic { get; set; }
    }
}
