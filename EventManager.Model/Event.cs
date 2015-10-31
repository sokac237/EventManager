using EventManager.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EventManager.Model
{
    [KnownType(typeof(Event))]
    public class Event : IEvent
    {

        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

         
    }
}
