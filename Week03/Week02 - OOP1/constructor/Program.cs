namespace constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's start!");
            Man x = new();
            Man y = new("Kate");
            // y.Name = "Test";
            // y.age = 5;
            // y.birthday = 1;
            
            //Ha a studentet példányosítom a Man konstruktora is lefut.
            //Ez azért van mert a Student a Man-ból származik és hogy 
            //legyen egy Student előtte kell egy stabil ember
            //mielőtt a student konstruktora sorra kerül.
            Student student = new();
            
            //Ez hibás mert a Studentnek nincs paraméteres konstruktora
            //A teachernek sincs, de ott csináltunk egy base konstruktor
            //hívást
            // Student student2 = new("Peter");
            
            Teacher teacher = new Teacher();
            Teacher teacher2 = new Teacher("Peter");

            Console.WriteLine(x.Name);
            Console.WriteLine(y.Name);
            Console.WriteLine(student.Name);
            Console.WriteLine(teacher.Name);
            Console.WriteLine(teacher2.Name);
            //Ez az adat azért érdekes, mert nem az instance-okhoz tartozik, hanem 
            //az emberekhez.
            Console.WriteLine(Man.Population);
        }
    }
    public class Man
    {
        //Ha nincs setter-e akkor nem lesz beállítható
        //private set -> Csak az osztályon belül látható
        //protected set -> osztályon belül és a leszármazott oszályokban
        public string Name { get; protected set; }
        
        //Kívülről nem érhető el
        protected int age;
        
        //csak a Man-on belül érhető el. A leszármazottakban sem érhető el.
        private int birthyday;
        public static int Population { get; set; }

        //Konstruktorok, lehet több is.
        //Nincs paramétere. Ha paraméter nélkül példányosítunk akkor
        //ez fut le, és a benne lévő értékeket kapják a propertyk.
        public Man()
        {
            Population++;
            Name = "John Doe";
            birthyday = 0;
        }
        //Ez fut le, ha paraméterrel példányosítok.
        public Man(string name)
        {
            Population++;
            Name = name;
        }

        //Ez olyan konstruktor, aminek nincs láthatósága és static. Ez csak
        //1X fut le az alkalmazás futtatása közben. (Statikus konstruktor)
        //Ha ilyen van ez indul elsőnek. Innen ugrik a rendes konstruktorra.
        static Man()
        {
            //Itt a cél az, hogy beállítsuk a populációnk számát az első futtatáskor
            Population = 10;
        }

        public void X()
        {
            Name = "aaa";
            birthyday = 11;
        }
    }

    public class Student : Man
    {
        private int[] grades;
        public Student()
        {
            //az age a Man-ból származó infó.
            age = 6;
            // birthyday = 1;
            grades = new int[] { 3, 2, 4, 3 };
        }
    }

    public class Teacher : Man
    {
        public Teacher()
        {
            Name = "Mr. " + Name;
            age = 77;
        }


        public Teacher(string name) : base("Mr." + name)
        {
            age = 77;
        }
    }
}
/*
 A konstruktorok célja, hogy a kezdőértékek, field-ek értékei beállításra
kerüljenek. Jellemzői, hogy van láthatóságuk, lehet paraméterük, nincs return 
és a nevének az osztály nevével = kell lenni.

Base
Base konstruktor hívás : annak az osztálynak a konstruktora amibtől örökölt.
A fenti példában a Man osztály 2. konstruktora lesz, mert ez a paraméteres 
konstruktor. Paraméterkén ez megkapja a példányosításkor definiált nevet, Mr-el
kiegészítve.
*/