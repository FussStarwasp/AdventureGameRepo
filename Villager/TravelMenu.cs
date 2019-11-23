using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villager
{
    public class TravelMenu:IMenuable
    {
        
        public string Name { get; set ; }
        public string Description { get; set; }
        public IList<IActionable> Choices { get; set; }

        public TravelMenu(string name, string description,IList<IActionable> choices)
        {
            Name = name;
            Description = description;
            Choices = choices;
        }
       

        public string Display(IList<IActionable> choices)
        {
            {
                Console.Clear();
                int count = 1;
                string result = Name +
                    Environment.NewLine + Description +
                    Environment.NewLine +
                    Environment.NewLine;

                Choices = choices;

                foreach (IActionable choice in Choices)
                {
                    result += count + ")" + choice.Name + Environment.NewLine;
                    count++;
                }

                result +=Environment.NewLine
                    + "Make your selection.";

                return result;

            }

            
        }
        public IActionable Selection( List<IActionable> actionables)
        {
           int selection = Convert.ToInt32(Console.ReadLine())-1;

            return actionables[selection];
            

        }
    }
}
