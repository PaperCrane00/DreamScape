using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScape.Data
{
    internal class Trade
    {
        public int Id { get; set; }
        public int User1Id { get; set; }
        public int User2Id { get; set; }
        public bool is_succesfull { get; set; } = false;
        public DateTime date { get; set; }
        public User User1 { get; set; }
        public User User2 { get; set; }
    }
}
