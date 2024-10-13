using System.Net.WebSockets;
using System.Threading.Channels;

namespace Inheritance04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //absztrakt osztályt nem lehet példányosítani
            //Man m = new Man();
            //m.SayHello();

            Student s = new Student();
            s.SayHello2();

            UniStudent us = new UniStudent();
            MedStudent ms = new MedStudent();
            ms.SayHello2();
            us.SayHello2();

            s.Eat();
            ms.Eat();
            us.Eat();

            Bike b = new Bike();
            b.Move();

            s.Move();
            ms.Move();
            us.Move();
        }
    }

    interface IMove
    {
        public void Move();
    }

    abstract class Man
    {
        //ez egy olyan tulajdonság, ami minden leszármazottra vonatkozik
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
        //ebben az esetben nem lehet törzset beletenni
        //mert ezt a példányokban kell defifiálni.
        public abstract void SayHello2();
    }
    //Nem öröklés az IMove. Egy ősosztály lehet és akárhány interface
    class Student : Man, IMove
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eat -- virtual code.");
        }

        public void Move()
        {
            Console.WriteLine("Running");
        }

        public override void SayHello2()
        {
            Console.WriteLine("Hello I'm a student");
        }

        //public void Move()
        //{
        //    Console.WriteLine("Running");
        //}
    }

    class UniStudent : Student
    {
        public override void Eat()
        {
            Console.WriteLine("Do some job -- Override code");
            base.Eat();
        }

        public override void SayHello2()
        {
            Console.WriteLine("Hello I'm a uni student");
        }

    }

    class MedStudent : Student
    {
        public override void Eat()
        {
            Console.WriteLine("Ask mom -- Override code");
        }

        public override void SayHello2()
        {
            Console.WriteLine("Hello I'm a med student");
        }
    }

    //Nem öröklést jelent, hanem azt, hogy megvalósítja az IMove interface-t.
    class Bike : IMove
    {
        //public void Move() { Console.WriteLine("Rolling"); }
        public void Move()
        {
            Console.WriteLine("Rolling");
        }
    }
}
/*
Most van egy logikailag nem illeszkedő másik osztály a Bike. Ebben van egy Move
de a Studentnek is van egy Move-ja, csak mást csinál. Hogyan tudom megoldani
hogy a Student tudjon kerékpározni és futni is?

Megoldás az interface.

Az interface nevét minden esetben I vel kell kezdeni,mert ez a szabály.
*/