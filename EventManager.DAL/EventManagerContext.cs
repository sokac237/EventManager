using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.DAL
{
    public class EventManagerContext : IEventManagerContext
    {
        public EventManagerContext()
        {
            Events = new List<EventEntity>() {
                new EventEntity()
                {
                    Id = 1,
                    Category = "Svatovi",
                    Date = DateTime.UtcNow,
                    Description = "Svatovi u sali Antunović, od 21:00",
                    Price = 3500
                },
                new EventEntity()
                {
                    Id = 2,
                    Category = "Svatovi",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "Svatovi u Zagrebu, večer od 20:00",
                    Price = 4500
                },
                new EventEntity()
                {
                    Id = 3,
                    Category = "Momačka",
                    Date = DateTime.UtcNow.AddDays(10),
                    Description = "Momačka zabava, šator, bez razglasa",
                    Price = 2500
                },
                new EventEntity()
                {
                    Id = 4,
                    Category = "Momačka",
                    Date = DateTime.UtcNow.AddDays(10),
                    Description = "Šator, Slavonski brod",
                    Price = 1800
                },
                new EventEntity()
                {
                    Id = 5,
                    Category = "Krstitke",
                    Date = DateTime.UtcNow.AddDays(25),
                    Description = "Kupina, 5",
                    Price = 900
                }
            };
        }

        public List<EventEntity> Events { get; set; }
    }
}
