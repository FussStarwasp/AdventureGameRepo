using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Brett", Locations.Home);

            ConsoleDisplay consoleDisplay = new ConsoleDisplay("Little Adventure");
            do
            {
                consoleDisplay.Display(player);

            } while (player.Name == "Brett");
                
            
            


        }
    }
}
