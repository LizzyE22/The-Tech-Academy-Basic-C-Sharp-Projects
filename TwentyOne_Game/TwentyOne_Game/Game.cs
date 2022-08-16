using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Game
{
    //adding "abstract" to the class locks it in, and it can only now be inherited from and cannot be instantiated
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get; set; }

        //adding abstract method that can only exist inside of an abstract class and contains no implementation
        //an abstract method states that any class inheriting this class must implement this method
        public abstract void Play();

        //a "virtual" method inside of an abstract class gets inherited by an inheriting class (TwentyOneGame), but
        // it has the ablity to override it
        public virtual void ListPLayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
