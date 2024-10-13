namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to palindrome project");
            Console.WriteLine(is_palindrome("abba"));
            Console.WriteLine(is_palindrome("Madam in Eden, I’m Adam."));
            Console.WriteLine(is_palindrome("Kakas"));
            Console.WriteLine(is_palindrome("ír"));
            Console.WriteLine(is_palindrome("Búb"));
        }

        static string is_palindrome(string palindrome)
        {
            string palindrome_cleared = palindrome.ToUpper().Replace(" ", "").Replace("’", "").Replace(".", "").Replace(",", "").Replace("'", "");
            return (palindrome_cleared == new string(palindrome_cleared.Reverse().ToArray())) ? $"{palindrome} : Yes, it is" : $"{palindrome} : No, it isn't";

        }
    }
}
