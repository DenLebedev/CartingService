using CartingService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartingService.BLL.Interface
{
    interface ICartBL
    {
        IEnumerable<Item> GetItems(int id);
        void AddItem(Item item);
        void RemoveItem(Item item);
    }
}
