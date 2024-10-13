using System.Net.WebSockets;
using System.Threading.Channels;

namespace Inheritance05
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

            //érték hozzárendelése a propertyhez
            s.Grade = 3;
            ms.Grade = 2;
            us.Grade = 5;

            Bike b = new Bike();
            b.Move();

            s.Move();
            ms.Move();
            us.Move();

            //Egyszerre mozgatás
            List<IMove> moveAble = new List<IMove>();
            moveAble.Add(b);
            moveAble.Add(us);
            moveAble.Add(ms);

            foreach (IMove move in moveAble) { move.Move(); }

            //vagy

            foreach (var item in moveAble) { item.Move(); }

            Console.WriteLine("//Rendezés megvalósítása");
            Student[] studs = new Student[3] { s, ms, us };
            //Kivételt kapunk, mert nics rendezési metódus megadva
            //a hiba javasolja az ICompararable interface megvalósítását
            Array.Sort(studs);

            foreach (var item in studs)
            {
                //Az evésből tudom azonosítani
                item.Eat();
                Console.WriteLine($"{item.Grade}");

            }


            Console.WriteLine("ToString felüldefiniálás példa");
            Console.WriteLine(s.ToString());
            //Így is jó.
            Console.WriteLine(us);
            Console.WriteLine(ms);
            //Ha nem definiáljuk felül a ToStringet akkor a típus nevét fogja kiirni
            Console.WriteLine(b);
        }
    }

    interface IMove
    {
        public void Move();
    }

    abstract class Man
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
        public abstract void SayHello2();
    }
    class Student : Man, IMove, IComparable<Student>
    {
        //A főősosztály ToString felüldefiniálása
        public override string ToString()
        {
            return $"I'm a Student, my Grad is {Grade}";
        }

        //property hozzáadása, hogy tudjuk a Studenteket rendezni
        public int Grade { get; set; }

        //Paraméterként vár egy másik Studentet és a két Student közül
        //- vagy + valamennyivel jelzi, hogy melyik Studentet kell előre
        //vagy hátra rakni a sorban.
        public int CompareTo(Student? other)
        {
            if (Grade == other.Grade) return 0;
            if (Grade > other.Grade) return -1;
            return 1;
        }

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
    }

    sealed class UniStudent : Student
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

    //A sealed megakadályozza a leszármaztatás lehetőségét.

    //class UniUniStudent : UniStudent
    //{ 
    //}

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

    class Bike : Object, IMove
    {
        public void Move()
        {
            Console.WriteLine("Rolling");
        }
    }
}
/*
Mi van akkor, ha egyszerre akarom mozgatni őket?
Az Object a főfő ősosztály, minden ebből származik le ezért nem is kell kiirni.
Ha ráállunk az osztály névre és F12-ve elővarázsoljuk a metainfókat akkor 
láthatóak lesznek az overridolható (virtual) metódusai.

*/