using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartingService.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public List<Item> Items { get; set; }

        // TODO: implement mapping a reference for working with LiteDB
    }
}
