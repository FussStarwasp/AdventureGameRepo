using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadiaTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Location home = new Location();
            home.Name = "Home";
            home.DamageDealt = 2;

            Location forest = new Location();
            forest.Name = "Forest";
            forest.DamageDealt = -5;

            Player player = new Player();
            player.Name = "George";
            player.MaxHealth = 10;
            player.CurrentLocation = home;

            Console.WriteLine(player.Name + player.CurrentLocation.Name + player.MaxHealth);

            player.MoveTo(forest);

            Console.WriteLine(player.Name + player.CurrentLocation.Name + player.MaxHealth);


        }
    }
}
