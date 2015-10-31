using EventManager.Model.Common;
using EventManager.Repository.Common;
using EventManager.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Service
{
    public class EventService : IEventService
    {
        protected IEventManagerRepository Repository { get; private set; }

        public EventService(IEventManagerRepository repo)
        {
            this.Repository = repo;
        }

        public List<IEvent> GetAllEvents()
        {
            return Repository.GetEvents().ToList();

        }


        public bool DeleteEvent(int Id)
        {
            return Repository.DeleteEvent(Id);
        }

    }
}
