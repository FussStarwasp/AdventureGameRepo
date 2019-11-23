using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public static class Locations
    {
        public static List<Location> HomeSurroundingLocations = new List<Location>();
        public static List<Location> LakeSurroundingLocations = new List<Location>();
        public static List<Location> ForestSurroundingLocations = new List<Location>();

        public static Location Home = new Location("Home", "Home Sweet Home", HomeSurroundingLocations);
        public static Location Forest = new Location("Forest", "A vastly wooded area, perfect for lumber and an orc ambush.", ForestSurroundingLocations);
        public static Location Lake = new Location("Lake", "A huge lake spans out before you.", LakeSurroundingLocations);


        static Locations()
        {
            
            HomeSurroundingLocations.Add(Forest);

            ForestSurroundingLocations.Add(Home);
            ForestSurroundingLocations.Add(Lake);

            LakeSurroundingLocations.Add(Forest);
        }


    }
}
