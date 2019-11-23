using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleSim
{
    public class Locations
    {
        string Name;
        string Description;
        string Resource;
        int QuantityOfResourcesAvailable;
        int MaximumAmountOfResources;
        int MinimumAmountOfResources;
        int ResourceRefreshRate;

        Locations(string name, string description, string resource, int quantityOfResourcesAvailable, int maximumAmountOfResources,
            int minimumAmountOfResources, int resourceRefreshRate)
        {

        }

    }
}
