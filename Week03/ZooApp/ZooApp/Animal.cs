using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    //Ez lesz az Állatok ősosztálya, ide jönnek a közös adatok
    abstract class Animal
    {
        //ha a field elé nem írok láthatóságot akkor private
        string name;

        protected Animal(string n)
        {
            name = n;
        }

        protected abstract void SayHello();

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
