namespace _10_Numin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hy Boy! Give me a number");
            GiveNumber2();
        }
        static int GiveNumber()
        {
            int i = 0;
            bool b = true;
            do
            {
                Console.WriteLine("Your number :");
                string s = Console.ReadLine();
                try
                {
                    i = int.Parse(s);
                    b = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("It is not a number");
                }
               
            } while (b);
            return i;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static int GiveNumber2()
        {
            int i = 0;
            while (!int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Not a number!");
            }            
            return i;
        }
    }
}
