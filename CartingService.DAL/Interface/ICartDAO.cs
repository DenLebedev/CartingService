using CartingService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartingService.DAL.Interface
{
    public interface ICartDAO
    {
        Cart Get(int id);
        void Save(Cart cart);
        void Update(Cart cart);
        void Delete(int id);
    }
}
