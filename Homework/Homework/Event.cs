using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Event
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public DateTime Time { get; set; }
        public Guid EventId { get; private set; }
        public List<Client> Clients { get; set; }

        public Event(string name = "Noname Event", string place = "none", DateTime time = new DateTime(), List<Client> clients = null)
        {
            EventId = Guid.NewGuid();

            Name = name;
            Place = place;

            if (time >= DateTime.Today)
                Time = time;
            else
                Time = DateTime.Today;

            if (clients == null)
                Clients = new List<Client>();
            else
                Clients = clients;
        }

        public void PostponeDays(int days)
        {
            Time.AddDays(days);
        }

        public void PostponeWeeks(int weeks)
        {
            Time.AddDays(weeks * 7);
        }

        public override string ToString()
        {
            return $"Event: {Name}, Place: {Place}, ID: {EventId}";
        }
    }
}
