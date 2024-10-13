namespace Q_R
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Q&R Project");
            q_and_r();
        }

        static void q_and_r()
        {
            string user_input_str1;
            string user_input_str2;

            while (true)
            {

                Console.WriteLine("Enter your first number : (x / X -> Exit)");
                user_input_str1 = Console.ReadLine();
                if (user_input_str1.Contains("x") || user_input_str1.Contains("X")) { break; }
                Console.WriteLine("Enter your second number : (x / X -> Exit)");
                user_input_str2 = Console.ReadLine();
                if (user_input_str2.Contains("x") || user_input_str2.Contains("X")) { break; }
                
                /*
                if (!int.TryParse(user_input_str1, out user_input_num1) || !int.TryParse(user_input_str2, out user_input_num2)) {
                    Console.WriteLine("These are not a number!");
                    continue;
                }*/

                try
                {
                    int quotient = int.Parse(user_input_str1) / int.Parse(user_input_str2); 
                    int remainder = int.Parse(user_input_str1) % int.Parse(user_input_str2);
                    Console.WriteLine($"Quotient : {quotient} Remainder : {remainder}");
                }
                catch (FormatException) 
                {
                    Console.WriteLine("These are not a number!");
                    continue;
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
    }
}
