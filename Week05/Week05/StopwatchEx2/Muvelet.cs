using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchEx2
{
    public abstract class Muvelet
    {
        public string Nev { get; set; }
        protected Muvelet(string name)
        {
            Nev = name;
        }
        protected abstract void MerendoMuveletVegrehajtása();

        public void Vegrehajt()
        {
            var stopwatch = Stopwatch.StartNew();
            MerendoMuveletVegrehajtása();
            Console.WriteLine($"{Nev} : {stopwatch.ElapsedMilliseconds} [ms]");
        }
    }
}
