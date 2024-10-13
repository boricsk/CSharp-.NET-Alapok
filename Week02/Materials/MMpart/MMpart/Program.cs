namespace MMpart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = GetDigit(654, 3);
            Console.WriteLine(x);

            x = GetDigit(4, 2);
            Console.WriteLine(x);

            x = GetDigit(654, 1);
            Console.WriteLine(x);

            x = GetDigit("789", 2);
            Console.WriteLine(x);
        }

        static int GetDigit(int origNum, int digit)
        {
            int lastDigit = 0;

            for (int i = 0; i < 3 - digit + 1; i++)
            {
                lastDigit = origNum % 10;
                origNum = origNum / 10;
            }

            return lastDigit;
        }


        static int GetDigit(string s, int digit)
        {            
            return s[digit - 1] - 48;
        }
    }
}