using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchEx3
{
    public class Meresek
    {
        public static void Meres(string Name,Action muvelet)
        {
            var stopwatch = Stopwatch.StartNew();
            muvelet();
            Console.WriteLine($"{Name} : {stopwatch.ElapsedMilliseconds} [ms]");
        }
    }
}
