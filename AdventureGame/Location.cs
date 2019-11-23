using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class Location
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Location> SurroundingLocations { get; set; }

        public Location(string name, string description,IList<Location> surroundinglocations)
        {
            Name = name;
            Description = description;
            SurroundingLocations = surroundinglocations;

        }
    }
}
