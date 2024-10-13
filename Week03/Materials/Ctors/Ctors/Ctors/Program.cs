namespace Ctors
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
            Student student = new();
           // Student student2 = new("Peter");
            Teacher teacher = new Teacher();
            Teacher teacher2 = new Teacher("Peter");

            Console.WriteLine(x.Name);
            Console.WriteLine(y.Name);
            Console.WriteLine(student.Name);
            Console.WriteLine(teacher.Name);
            Console.WriteLine(teacher2.Name);
            Console.WriteLine(Man.Population);
        }
    }

    public class Man
    {
        public string Name { get; protected set; }
        protected int age;
        private int birthyday;
        public static int Population { get; set; }


        public Man()
        {
            Population++;
            Name = "John Doe";
            birthyday = 0;
        }

        public Man(string name)
        {
            Population++;
            Name = name;            
        }

        static Man()
        {
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