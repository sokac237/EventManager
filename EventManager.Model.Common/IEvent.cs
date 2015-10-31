using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Model.Common
{
    public interface IEvent
    {
        int Id { get; set; }

        string Description { get; set; }

        DateTime Date { get; set; }

        decimal Price { get; set; }

        string Category { get; set; }
    }
}
