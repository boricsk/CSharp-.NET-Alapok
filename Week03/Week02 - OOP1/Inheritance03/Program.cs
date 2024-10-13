using System.Net.WebSockets;
using System.Threading.Channels;

namespace Inheritance03
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
        }
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

    class Student : Man
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eat -- virtual code.");
        }

        public override void SayHello2()
        {
            Console.WriteLine("Hello I'm a student");
        }
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
}
/*
Tegyük fel, hogy a Man-ból leszármazottakkal akaorok csinálni valamit,
de a Man-al nem. A Man ebben az esetben legyen egy elvont fogalom,
mert a példányai kézzel foghatóak, de maga az ősosztály nem. Ekkor
az abstract kulcsszót kell használni, ekkor a Man nem lesz közvetlenül
példányosítható. akkor jó választás, ha az ősolytályban olyan tulajdonságokat 
szeretnék definiálni, ami sok példányra is vonatkozik, viszont az ősosztály
megvalósításának nincs értelme. Olyan közös tulajdonságokat kell tartalmaznia
amelyek a leszármazási lánc összes tagjára vonatkoznak.

A SayHellot-meg lehet jelölni absztrakt metódusnak, bár nem kötelező.
Ha használom a SayHello2-t akkor minden példányban célszerű overrideolni
mert csak akkor lesznek különbözőek a funkciók.

Csak egyszeres leszármazási lánc készíthető, olyan nincs, hogy 
class MedStudent : Student, Man
*/