using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>() 
            { 
                new Client("Petro", "931299312"), 
                new Client("Vasya", "879423") 
            };

            EventService eventService = new EventService()
            {
                Events = new List<Event>()
                { 
                    new Event("Film", "Cinema", DateTime.Today.AddDays(1), clients),
                    new Event("Football", "Stadium", DateTime.Today.AddDays(5), clients),
                }
            };

            eventService.FindEvent(DateTime.Today.AddDays(1)); // шукає усі за датаю

            Console.WriteLine();

            eventService.FindEventsInRange(DateTime.Today.AddDays(1), DateTime.Today.AddDays(5)); // шукає усі за діапазоном дат

            Console.WriteLine();

            eventService.FindByClient(clients[0]); // шукає усі за зареєстрованим клієнтом
        }
    }
}
