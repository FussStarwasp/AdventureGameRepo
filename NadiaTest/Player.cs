using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadiaTest
{
    public class Player

    {
        public string Name { get; set; }
        public int MaxHealth
        {
            get
            {
                if (MaxHealth > 10)
                {
                    return 10;
                }
                return MaxHealth;
            }
            set { MaxHealth = value; }
        }
            
            
        public Location CurrentLocation { get; set; }

        public void MoveTo(Location location)
        {
            CurrentLocation = location;
            MaxHealth = MaxHealth - location.DamageDealt;

        }

    }
}
