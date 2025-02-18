using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamScape.Data
{
    internal class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StatId { get; set; }
        public int TypeId { get; set; }
        public Stat Stat { get; set; }
        public Type Type { get; set; }
    }
}
