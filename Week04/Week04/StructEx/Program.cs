namespace StructEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C c = new();
            S s = new();

            Change(c, s);

            Console.WriteLine(c.A); //11
            Console.WriteLine(s.A); //1 Mert value type és ez nem ad vissza a hívó programnak

        }

        static void Change(C c, S s)
        {
            c.A = 11;
            s.A = 11;
        }
    }

    interface II { }

    class C : Object
    {
        public int A { get; set; }
        public C()
        {
            A = 1;
        }
    }

    struct S : II
    {
        public int A { get; set; }
        public S()
        {
            A = 1;
        }
    }
}
