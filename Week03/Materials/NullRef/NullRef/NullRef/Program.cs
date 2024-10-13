namespace NullRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem p = new();
            p.PrintOut();

            Console.WriteLine("----");

            int a = 1;
            int[] b = new int[1] { 2 };
            p.PrintOut2(ref a, b);
            Console.WriteLine(a);
            Console.WriteLine(b[0]);

            string s = "123";
            int x;

            int.TryParse(s, out x);

            string? s2 = null;
            string? s3 = "";
            s3 = null;

            int? r = null;
            Console.WriteLine(r);


            if (string.IsNullOrEmpty(s2))
            {

            }

            Console.WriteLine("----");
            Console.WriteLine(p.Counter?.Count());
            

        }
    }

    class Problem
    {
        int x;
        int[] xs;
        public int[] Counter { get; set; }

        public Problem()
        {
               // x = 0;
                xs = new int[2];
                xs[0] = 0;
                xs[1] = 1;

        }

        public void PrintOut()
        {
            Console.WriteLine(x);
            Console.WriteLine(xs[1]);
        }

        public void PrintOut2(ref int y, int[] ys) 
        {
            // y = 10;
            ys[0] = 20;
        }

    }
}