[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(EventManager.WebUI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(EventManager.WebUI.App_Start.NinjectWebCommon), "Stop")]

namespace EventManager.WebUI.App_Start
{
    using System;
    using System.Web;
    using System.Web.Http;
    using System.Linq;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.WebApi;


    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var settings = new NinjectSettings();
            settings.LoadExtensions = true;
            settings.ExtensionSearchPatterns = settings.ExtensionSearchPatterns.Union(new string[] { "EventManager.*.dll" }).ToArray();
            var kernel = new StandardKernel(settings);
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                // Install Ninject-based IDependencyResolver into the Web API configuration to set Web API Resolver
                GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);
   
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            var eventService = kernel.Get<EventManager.Service.Common.IEventService>();
            kernel.Rebind<EventManager.Service.Common.IEventService>().To(eventService.GetType());
        }        
    }
}
