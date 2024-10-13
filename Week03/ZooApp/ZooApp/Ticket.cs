using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    internal class Ticket
    {
        DateTime sold;
        double price;
        public string Name { get; set; }

        public Ticket(double p, string name)
        {
            price = p;
            Name = name;
            sold = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Sold at : {sold}, valid for {Name} - Price : {price}";
        }
    }
}
