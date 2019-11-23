using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public interface IDisplayable
    {
        string Title { get; set; }
        string PlayerStats { get; set; }
        string SurroundingLocationsToString { get; set; }

        void Display(Player player);
        


    }
}
