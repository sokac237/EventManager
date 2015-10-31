using System;
using EventManager.DAL;
using EventManager.Model;
using EventManager.Model.Common;
using EventManager.Repository.Common;

namespace EventManager.Repository
{
    public class DIModule : Ninject.Modules.NinjectModule
    {
       
        public override void Load()
        {
            AutoMapper.Mapper.CreateMap<EventEntity, Event>().ReverseMap();
            AutoMapper.Mapper.CreateMap<EventEntity, IEvent>().ReverseMap();
            AutoMapper.Mapper.CreateMap<IEvent, Event>().ReverseMap();

            Bind<IEventManagerContext>().To<EventManagerContext>().InSingletonScope();
            Bind<IEventManagerRepository>().To<EventManagerRepository>();
        }

       
    }
}
