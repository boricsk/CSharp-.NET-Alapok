namespace simplifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to simplifier project");
            Console.WriteLine(simplifier("mmmMMmmmOmmm"));
            Console.WriteLine(simplifier("caaakkeeeeeLLL234lawwww"));
            Console.WriteLine(simplifier("cicacicacicacccciccc"));
            Console.WriteLine(simplifier("ffffatttthhhhheeer"));

        }

        static string simplifier(string s)
        {
            string ret = "";
            s = s.ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                //Console.WriteLine(s[i]);
                if (i == 0)
                {
                    ret += s[i];
                }
                else
                {
                    if (s[i] != s[i - 1]) { ret += s[i]; };
                }
            }
            return ret;
        }
    }
}
