using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    internal class Horse : Animal
    {
        public Horse(string n) : base(n)
        {
            
        }
        protected override void SayHello()
        {
            Console.WriteLine("Nyihaha");
        }
    }
}
