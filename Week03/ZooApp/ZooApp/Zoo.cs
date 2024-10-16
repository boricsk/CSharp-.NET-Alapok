using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    internal class Zoo
    {
        //Kívülről nem állítható a name, csak a konstruktor tud értéket adni //
        public string Name { get; }
        public List<Animal> animals { get; }

        List<Ticket> tickets = new List<Ticket>();

        public Zoo(string name)
        {
            Name = name;
            //A referencia típusokat inicializálni kell a használat előtt
            tickets = new List<Ticket>();
            animals = new List<Animal>();
        }
        public void SellTicket(Ticket t)
        {
            tickets.Add(t);
            Console.WriteLine(t);
        }

        public void PrintOutAni()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        public void AddAni(Animal animal)
        {
            animals.Add(animal);
        }
    }
}
