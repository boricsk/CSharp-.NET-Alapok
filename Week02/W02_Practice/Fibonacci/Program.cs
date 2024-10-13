namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fibonacci project");
            fibonacci(3, 5, 10);
        }

        static void fibonacci(int n1, int n2, int len)
        {
            List<int> fib_list = new List<int>();
            fib_list.Add(n1);
            fib_list.Add(n2);
            for (int i = 2; i < len; i++)
            {
                fib_list.Add(fib_list[i - 1] + fib_list[i - 2]);
            }
            for (int i = 0; i < fib_list.Count; i++)
            {
                Console.WriteLine(fib_list[i]);
            }
        }
    }
}