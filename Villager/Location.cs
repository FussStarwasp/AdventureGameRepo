using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villager
{
    public class Location : IActionable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<IActionable> SurroundingLocations { get; set; }

        public Location(string name, string description,List<IActionable> surroundingLocations)
        {
            Name = name;
            Description = description;
            SurroundingLocations = surroundingLocations;
            

        }
    }
}
