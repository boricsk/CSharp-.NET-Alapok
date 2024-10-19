using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace AdvBook
{
    internal class Player
    {
        public string Name { get; }
        public int Health { get; set; } = 100;
        public int Score { get; set; } = 0;
        public Dictionary<string, bool> capabilities { get; set; }
        public Dictionary<string, string> tools { get; set; }
        public Player(string name)
        {
            Name = name;
        }
        public bool Fight()
        {
            bool ret = false;
            Random rnd = new Random();
            int enemyPower = rnd.Next(0, 99);
            //Console.WriteLine($"Enemy : {enemyPower}, You : {power}");
            if (enemyPower < Health) { ret = true; Score += 25; }
            Progress.PrintProgress("Harc");
            Health -= 10;
            return ret;
        }
        public void AddTool(string ToolId, string ToolName)
        {
            tools.Add(ToolId, ToolName);
        }
        public void Learn(string CapId)
        {
            if (Health <= 10)
            {
                Console.WriteLine($"Nincs elég energiád a tanuláshoz. Az energiaszinted : {Health} %");
            }
            else
            {
                capabilities.Add(CapId, true);
                Health -= 10;
                Score += 5;
            }
        }
        public void GetHealth()
        {
            Health += 50;
            if (Health > 100) { Health = 100; }
            Console.WriteLine($"Az energiaszinted : {Health} %");
        }
    }
}
