using System.Net.WebSockets;
using System.Threading.Channels;

namespace Inheritance02
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

            s.Eat();
            ms.Eat();
            us.Eat();
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
        //Ezt fogjuk felülírni a példányokban, olyan késszég
        //amit a leszármazottakban fogunk pontosan megvalósítani.
        public virtual void Eat()
        {
            Console.WriteLine("Eat -- virtual code.");
        }

    }

    class UniStudent : Student
    {
        public override void Eat()
        {
            Console.WriteLine("Do some job -- Override code");
            //Ősosztály metódushívása, mert ezt már megcsináltuk
            base.Eat();
        }

    }

    class MedStudent : Student
    {
        public override void Eat()
        {
            Console.WriteLine("Ask mom -- Override code");
            //base.Eat();
        }
    }
}
/*
Ha azt szeretném, hogy az evés képesség mindenkinek testre szabott
legyen akkor a virual és override kulcsszavakat kell használni.
*/