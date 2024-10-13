using System.Net.WebSockets;

namespace pract_isbn_check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isbn_check("978-0-13-586144-8"));
        }

        static bool isbn_check(string isbn)
        {
            string only_nums = isbn.Replace("-", "").Replace(" ", "");
            if (only_nums.Length != 13) { return false; }

            List<int> odd_list = new List<int>();
            List<int> even_list = new List<int>();

            for (int i = 0; i <= only_nums.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    //ha simán (int)only_nums[i] vel hivatkozol rá akkor az ascii kód lesz benne.
                    even_list.Add(int.Parse(only_nums[i].ToString()));
                }else
                {
                    odd_list.Add(int.Parse(only_nums[i].ToString()) * 3);
                }
            }
            //foreach (int i in odd_list) { Console.WriteLine(i); }
            //Console.WriteLine();
            //foreach (int i in even_list) {Console.WriteLine(i); }
            
            //Console.WriteLine($"Summ : {odd_list.Sum() + even_list.Sum()}");
            return (odd_list.Sum() + even_list.Sum()) % 10 == 0;
        }
    }
}
