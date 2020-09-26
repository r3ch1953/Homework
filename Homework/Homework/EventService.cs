using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class EventService
    {
        public List<Event> Events { get; set; }

        public EventService()
        {
            Events = new List<Event>();
        }

        public void AddEvent(Event e)
        {
            Events.Add(e);
        }

        public void DelEvent(Event e)
        {
            Events.Remove(e);
        }

        public void ClearEvents()
        {
            Events.Clear();
        }

        public void FindEvent(DateTime date)
        {
            var events = Events.FindAll(x => x.Time.Equals(date));
            events.ForEach(x => Console.WriteLine(x));
        }

        public void FindEventsInRange(DateTime leftBorder, DateTime rigthBorder)
        {
            var events = Events.FindAll(x => x.Time >= leftBorder || x.Time <= rigthBorder);
            events.ForEach(x => Console.WriteLine(x));
        }

        public void FindByClient(Client client)
        {
            var events = Events.FindAll(x => x.Clients.Contains(client));
            events.ForEach(x => Console.WriteLine(x));
        }
    }
}
