using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villager
{
    public static class Locations
    {

        public static List<IActionable> SurroundingLocationsHome = new List<IActionable>();
        public static List<IActionable> SurroundingLocationsForest = new List<IActionable>();
        public static List<IActionable> SurroundingLocationsLake = new List<IActionable>();
        public static List<IActionable> SurroundingLocationsMarket = new List<IActionable>();
        public static List<IActionable> SurroundingLocationsTheLagoon = new List<IActionable>();

        
        public static Location Home = new Location("Home", "Home Sweet Home",SurroundingLocationsHome);
        public static Location Forest = new Location("Forest", "This area is heavily wooded, a perfect place to find lumber...and Orcs",SurroundingLocationsForest);
        public static Location Lake = new Location("Lake", "The lake's surface shimers in the sunlight.",SurroundingLocationsLake);
        public static Location Market = new Location("Market", "Many people come here to trade, be wary of pick pockets and cut throats.", SurroundingLocationsMarket);
        public static Location TheLagoon = new Location("The Lagoon", "You arrive at the lagoon to find the sand covered in shells.",SurroundingLocationsTheLagoon);

        public static void PopulateLocations()
        {
            Home.SurroundingLocations.Add(Lake);
            Home.SurroundingLocations.Add(Forest);

            Lake.SurroundingLocations.Add(Home);
            Lake.SurroundingLocations.Add(Market);

            Forest.SurroundingLocations.Add(Home);
            Forest.SurroundingLocations.Add(TheLagoon);




        }
        

        

    }
}
