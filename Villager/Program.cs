using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villager
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IActionable> actionables = new List<IActionable>();
            
            Player player = new Player();
            player.Name = "Adventurer";
            player.CurrentLocation = Locations.Home;
            Locations.PopulateLocations();
          
            TravelMenu travelMenu = new TravelMenu("Travel Menu","There are many paths to follow:",player.CurrentLocation.SurroundingLocations);

            Console.WriteLine(travelMenu.Display(player.CurrentLocation.SurroundingLocations));
            player.CurrentLocation = (Location)travelMenu.Selection(player.CurrentLocation.SurroundingLocations);
            Console.WriteLine(travelMenu.Display(player.CurrentLocation.SurroundingLocations));

            Console.ReadLine();




        }
    }
}
