using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villager
{
    public interface IMenuable
    {
        string Name { get; set; }
        string Description { get; set; }
        IList<IActionable> Choices { get; set; }

        string Display(IList<IActionable> choices);
        


    }
}
