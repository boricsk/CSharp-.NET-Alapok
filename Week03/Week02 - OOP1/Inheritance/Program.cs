using System.Net.WebSockets;
using System.Threading.Channels;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man m = new Man();
            m.SayHello();

            Student s = new Student();
            s.SayHello();

            UniStudent us = new UniStudent();
            MedStudent ms = new MedStudent();
            ms.SayHello();
            us.SayHello();


        }
    }

    class Man
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }

    class Student : Man
    {
        public void Eat()
        {
            Console.WriteLine("Eat");
        }

    }

    class UniStudent : Student
    {
        public void Eat()
        {
            Console.WriteLine("Do some job");
            //Ősosztály metódushívása, mert ezt már megcsináltuk
            base.Eat(); 
        }

    }

    class MedStudent : Student
    {
        public void Eat()
        {
            Console.WriteLine("Ask mom");
            base.Eat();
        }
    }
}
/*
Jelen esetben az ember tud köszönni, de nem tud enni. enni csak a 
Studentől lefelé tudnak. Ha azt mondom, hogy a példányok is ugyanazzal
a névvel tudnak enni, akkor kapok egy kis figyemeztetést zöld hullám
vonal alakjában, ami azt jelenti, hogy a sutudent evési képességet 
eljejtettem mert a példányok is ezt a nevet használják.

*/