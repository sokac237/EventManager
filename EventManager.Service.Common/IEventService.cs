using EventManager.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Service.Common
{
    public interface IEventService
    {
        List<IEvent> GetAllEvents();

        bool DeleteEvent(int Id);
    }
}
