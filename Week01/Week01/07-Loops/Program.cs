namespace _07_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //Hátultesztelős
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 10);

            int k = 0;
            while (k < 10)
            {
                Console.WriteLine(k);
                k++;
            }

            int[] ivalues = { 5, 3, 8, 1, };
            
            //       var
            foreach (int onei in ivalues)
            {
                Console.WriteLine(onei);
            }

            //var esetén a fordító megpróbálja kitalálni a típust

            var num = 1; //int32 típus lesz
            var s = "aaa"; //string lesz
            var num2 = 1.0;

            Console.WriteLine("---------------------------");
            for (int i = 32; i<255; i++)
            {
                Console.WriteLine($"{i} -- {(char)(i)}");
            }
        }
    }
}
