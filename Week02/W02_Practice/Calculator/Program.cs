namespace Calculator
{
    internal class Program
    {
        static string user_input_str1 = "";
        static string user_input_str2 = "";
        static int user_input_int1 = 0;
        static int user_input_int2 = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to calculator project");
            calculator();
        }
        static void calculator()
        {
            while (get_numbers())
            {
                try
                {                    
                    get_menu(user_input_str1, user_input_str2);
                    var choice = Console.ReadLine();

                    switch (choice[0])
                    {
                        case 'a': 
                        case 'A':
                            Console.WriteLine($"Summ : {user_input_int1 + user_input_int2}");
                            break;
                        case 's':
                        case 'S':
                            Console.WriteLine($"Difference : {user_input_int1 - user_input_int2}");
                            break;
                        case 'm':
                        case 'M':
                            Console.WriteLine($"Multiply : {user_input_int1 * user_input_int2}");
                            break;
                        case 'd':
                        case 'D':
                            Console.WriteLine($"Division : {user_input_int1 / user_input_int2}");
                            break;
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Division by zero error!");
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("Other error!");
                    //Ha több catch ág van akkor ez mindíg a végére kell
                    continue;
                }
            }
        }
        static bool get_numbers()
        {
            //try blokkból nem tér vissza!!

            Console.WriteLine("Enter your first number : (x / X -> Exit)");
            user_input_str1 = Console.ReadLine();
            if (user_input_str1.Contains("x") || user_input_str1.Contains("X")) { return false; }
               
            Console.WriteLine("Enter your second number : (x / X -> Exit)");
            user_input_str2 = Console.ReadLine();
            if (user_input_str2.Contains("x") || user_input_str2.Contains("X")) { return false; }
            
            try
            {
                user_input_int1 = int.Parse(user_input_str1);
                user_input_int2 = int.Parse(user_input_str2);
            }
            catch (FormatException)
            {
                Console.WriteLine("These are not a number!");
                get_numbers();
            }
            catch (Exception)
            {
                Console.WriteLine("Other error!");
                //Ha több catch ág van akkor ez mindíg a végére kell
                get_numbers();
            }

            return true;
        }
        static void get_menu(string s1, string s2)
        {
            Console.WriteLine("Calculator menu");
            Console.WriteLine($"A - Add {s1} and {s2}");
            Console.WriteLine($"S - Substract {s1} and {s2}");
            Console.WriteLine($"M - Multiply {s1} and {s2}");
            Console.WriteLine($"D - Division {s1} and {s2}");
            Console.WriteLine("Please select an operation.");
        }
    }
}
