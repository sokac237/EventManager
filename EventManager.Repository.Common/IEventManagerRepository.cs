using EventManager.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Repository.Common
{
    public interface IEventManagerRepository
    {
        List<IEvent> GetEvents();

        bool DeleteEvent(int Id);
       
    }
}
