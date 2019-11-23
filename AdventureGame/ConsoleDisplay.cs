using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class ConsoleDisplay : IDisplayable
    {
        public string Title { get; set ; }
        public string PlayerStats { get; set; }
        public string SurroundingLocationsToString { get; set; }
        public string ConsoleScreen { get; set; }

        public ConsoleDisplay(string title)
        {
            Title = title;

        }

        public void Display(Player player)
        {
            Console.Clear();
            int count = 1;
            PlayerStats ="Player Name:"+ player.Name
                + Environment.NewLine
                +Environment.NewLine
                +"Current Location:"+ player.CurrentLocation.Name;

            SurroundingLocationsToString = "Please select another destination to travel to:" + Environment.NewLine
                + Environment.NewLine;

            foreach (Location location in player.CurrentLocation.SurroundingLocations)
            {
                SurroundingLocationsToString += count + ")" + location.Name + Environment.NewLine;
                count++;
            }


            ConsoleScreen = "\t\t" + Title
                + Environment.NewLine
                + Environment.NewLine
                + PlayerStats
                + Environment.NewLine
                +Environment.NewLine
                + SurroundingLocationsToString;

            Console.WriteLine(ConsoleScreen);
            player
            
        }
    }
}
