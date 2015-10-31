using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.DAL
{
    public interface IEventManagerContext
    {
        List<EventEntity> Events { get; set; }
    }
}
