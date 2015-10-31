using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventManager.Service.Common;
using EventManager.Model.Common;


namespace EventManager.WebUI.Controllers
{
    public class EventManagerController : Controller
    {
       
        public EventManagerController(IEventService service)
        {
            this.Service = service;
        }


        protected IEventService Service;

       

        public ViewResult List()
        {
             return View(Service.GetAllEvents());
        }


        public ViewResult Edit(int Id)
        {

            return View(Service.GetAllEvents().FirstOrDefault(p => p.Id == Id));
        }


        [HttpPost]
        public ActionResult Delete(int eventId)
        {
            return RedirectToAction("List");
        }
    }
}