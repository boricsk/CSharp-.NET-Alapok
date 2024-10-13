namespace _08_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hibás lesz mert a szöveg tartalma nem szám. Ha pl "12" lenne akkor sikeres a parsolás 
            try
            {
                int i = int.Parse("12"); //FormatException
                Console.WriteLine("Good");

                int a = 0;
                int b = 10;
                Console.WriteLine(b/a);
            }
            catch (FormatException) // Meg lehet határozni hogy az adott catch milyen típusú kivételekre vonatkozzon.
            {
                Console.WriteLine("Not Good");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("0 osztás");
            }
            catch (Exception)
            {
                Console.WriteLine("Other error");
                //Ha több catch ág van akkor ez mindíg a végére kell
            }
            finally
            {
                Console.WriteLine("Mindíg lefut");
            }
        }
    }
}
