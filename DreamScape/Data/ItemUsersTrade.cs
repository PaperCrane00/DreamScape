using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScape.Data
{
    internal class ItemUsersTrade
    {
        public int Id { get; set; }
        public int ItemUserId { get; set; }
        public int TradeId { get; set; }
        public bool Completed { get; set; } = false;
        public ItemUser ItemUser { get; set; }
        public Trade Trade { get; set; }
    }
}
