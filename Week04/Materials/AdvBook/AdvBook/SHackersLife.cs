using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvBook
{
    internal class SHackersLife: Story
    {
        private List<Possibility> Possibilities { get; }
        string StoryTitle { get; set; }
        public SHackersLife(Player player, string title): base(player, title)
        {
            Possibilities = new List<Possibility>();
            StoryTitle = title;
            Possibilities.Add(new("1", "Az első nap", $"{player.Name} izgatott volt ébredés után, ma lesz az első napja az FBI-nál. Egy phising -el foglalkozó bandát kell felszámolni. Meg is kapta a darkwebes oldaluk címét", new List<string> { "2", "7"}));
            Possibilities.Add(new("2", "Az oldal", "Bonyolult oldallal találta szemben magát, de szerencsére a HTML kódban talált egy ott felejtett kommentet, ami koordinátáknak tünt.", new List<string> { "3" }));
            Possibilities.Add(new("3", "A helyszín", $"Miután megszerezte a koorinátákat kocsiba pattant és a helyszínre sietett, ami egy elhagyatott raktár volt. Mikor belépett tüzelni kezdtek rá.", new List<string> { "8", "2" }));
            Possibilities.Add(new("4", "Az SD kártya", "A tűzharc után gondosan átvizsgálta a helyszínt, sajnos előre tudtak a látogatásáról és mindent adattárolót megsemmisítettek. Azonban az egyikk billentyűzet alatt egy SD kártyát talált.", new List<string> { "5"}));
            Possibilities.Add(new("5", "Az áttörés", $"{player.Name} remek munkát végzett, ugyanis a kártyán egy csomó bizonyítékot és neveket találtak, ami elég a letartóztatáshoz", new List<string> { "6" }));
            Possibilities.Add(new("6", "A leszámolás", $"A megszerzett bizonyítékok alapján sikeresen letartóztattak mindenkit. {player.Name} remek munkát végeztél! ", new List<string> { }));
            Possibilities.Add(new("7", "WEB Hacking tanulás", $"{player.Name} now start learning WEB hacking ...", new List<string> { "2" }));
            Possibilities.Add(new("8", "Harc", $"{player.Name} felvette a harcot az ellenséggel...", new List<string> { "2" }));

        }
        public override void Run()
        {
            Possibility currentChoice = Possibilities[0];
            while (true)
            {
                PrintSences.PrintSence(currentChoice, ThePlayer, StoryTitle);
                if (currentChoice.NextPos.Count > 0 && ThePlayer.Health > 0)
                {
                    foreach (string id in currentChoice.NextPos)
                    {
                        Possibility? possibility = GetChoice(id);
                        Console.WriteLine($"{id} : {possibility?.Title ?? "Helytelen"}");
                    }
                    string StoryId;
                    Possibility? NextChoice;
                    do
                    {
                        StoryId = ReadInput.GetChoice();

                    } while (((NextChoice = GetChoice(StoryId)) == null) || !currentChoice.NextPos.Contains(StoryId));
                    currentChoice = NextChoice;

                    switch (currentChoice.Id)
                    {
                        case "6":
                            currentChoice = Possibilities[5];
                            PrintSences.PrintSence(currentChoice, ThePlayer, StoryTitle);
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;
                        case "8":
                            if (ThePlayer.Fight()) 
                            { 
                                Console.WriteLine("Legyőzted az ellenséget");
                                ThePlayer.AddTool("SD Card");
                                Console.ReadLine(); 
                                currentChoice = Possibilities[3];
                            } else 
                            { 
                                Console.WriteLine("Meghaltál"); 
                                Environment.Exit(0);
                            }
                            break;
                            
                        case "2":
                            if (!ThePlayer.capabilities.Contains("WEB hacking")) 
                            {
                                Console.WriteLine("Nincs WEB hacking képességed!");
                                Console.ReadKey();
                                currentChoice = Possibilities[0];
                            }
                            break;
                        case "7":
                            PrintSences.PrintSence(currentChoice, ThePlayer, StoryTitle);
                            ThePlayer.Learn("WEB hacking");
                            currentChoice = Possibilities[0];
                            break;
                    }
                }
                else 
                {
                    Console.WriteLine("End");
                    break;
                }
            }
        }
        private Possibility? GetChoice(string id)
        {
            foreach (Possibility possibility in Possibilities)
            {
                if (possibility.Id == id)
                {
                    return possibility;
                }
            }
            return null;
        }
    }
}
