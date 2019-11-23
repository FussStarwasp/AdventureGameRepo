using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class Player
    {
        public string Name { get; set; }
        public Location CurrentLocation { get; set; }
        public int Gold { get; set; }

        public Player(string name, Location currentLocation)
        {
            Name = name;
            CurrentLocation = currentLocation;
        }

        public void Moveto(Player player)
        {
            int selection = Convert.ToInt32(Console.ReadLine())-1;
            player.CurrentLocation = player.CurrentLocation.SurroundingLocations[selection];

            
        }
    }
}
