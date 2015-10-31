using System;
using EventManager.Service.Common;

namespace EventManager.Service
{
    public class DIModule : Ninject.Modules.NinjectModule
    {
        #region Methods

        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            Bind<IEventService>().To<EventService>();
        }

        #endregion Methods
    }
}
