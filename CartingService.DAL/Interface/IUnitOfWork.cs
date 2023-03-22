using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartingService.DAL.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ICartDAO Cart { get; }
    }
}
