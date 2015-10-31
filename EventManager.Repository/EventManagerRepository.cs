using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManager.DAL;
using EventManager.Model.Common;
using EventManager.Model;
using EventManager.Repository.Common;

namespace EventManager.Repository
{
    public class EventManagerRepository : IEventManagerRepository
    {
        protected IEventManagerContext Context { get; private set; }

        public EventManagerRepository(IEventManagerContext context)
        {
            this.Context = context;
        }


        public List<IEvent> GetEvents()
        {
            AutoMapper.Mapper.CreateMap<EventEntity, Event>().ReverseMap();
            AutoMapper.Mapper.CreateMap<EventEntity, IEvent>().ReverseMap();


            return new List<IEvent>(AutoMapper.Mapper.Map<List<Event>>(Context.Events));
        }


        public bool DeleteEvent(int Id)
        {
            return Context.Events.Remove(Context.Events.First(p => p.Id.Equals(Id)));
        }


    }
}
