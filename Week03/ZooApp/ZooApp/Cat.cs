using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    internal class Cat : Animal
    {

        public Cat(string n): base(n) { }

        protected override void SayHello()
        {
            Console.WriteLine("Nyaúúú");
        }
    }
}
