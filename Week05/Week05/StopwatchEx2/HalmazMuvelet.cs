using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchEx2
{
    internal class HalmazMuvelet: Muvelet
    {
        public HalmazMuvelet() : base("Halmaz")
        {
            
        }
        protected override void MerendoMuveletVegrehajtása()
        {
            var random = new Random();
            var set = new HashSet<int>();
            foreach (var szam in Enumerable.Range(1, 100000))
            {
                var r = random.Next(0, szam);
                if (!set.Contains(r)) { set.Add(r); }
            }
        }
    }
}
