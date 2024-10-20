using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvBook
{
    public static class ReadInput
    {
        public static string GetName() 
        { 
            string? getstring = null;

            while (string.IsNullOrWhiteSpace(getstring)) 
            {
                Console.WriteLine("Kérem a játékos nevét : ");
                getstring = Console.ReadLine();
            }
            return getstring;
        }

        public static int GetNumber() 
        {
            int ret;
            Console.WriteLine("Kérem válasszon :");
            while (!int.TryParse(Console.ReadLine(),out ret)) 
            {
                Console.WriteLine("A bevitt érték nem szám!");
            }
            return ret; 
        }
        public static string GetChoice()
        {
            string? ret = null;
            Console.WriteLine("Kérem válasszon :");
            while (string.IsNullOrWhiteSpace(ret))
            {
                ret = Console.ReadLine();
            }
            return ret;
        }
    }
}
