using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var myGameList = new List<string>() { "Dragon Age", "Destiny", "Assassins's Creed", "Warhammer", " Nba2k" };
            var gamesOrdered = myGameList.OrderBy(s=> s.Length);
            foreach(var game in gamesOrdered)
            {
                Console.WriteLine(game);
            }
            Console.ReadLine();
            var squares = Enumberable.R
            
        }
    }
}
