using System.Diagnostics;

namespace StopwatchEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var stopwatch = Stopwatch.StartNew();
            var list = new List<int>();
            foreach (var szam in Enumerable.Range(1, 100000)) 
            { 
                var r = random.Next(0, szam);
                if (!list.Contains(r)) { list.Add(r); }
            }
            Console.WriteLine($"Lista : {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Lista : {stopwatch.ElapsedTicks} Ticks");
            

            stopwatch.Restart();

            var set = new HashSet<int>();
            foreach (var szam in Enumerable.Range(1, 100000))
            {
                var r = random.Next(0, szam);
                if (!set.Contains(r)) { set.Add(r); }
            }

            Console.WriteLine($"Halmaz : {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Halmaz : {stopwatch.ElapsedTicks} Ticks");
        }
    }
}
