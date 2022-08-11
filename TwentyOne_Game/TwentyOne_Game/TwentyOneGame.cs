using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_Game
{
    //public class TwentyOneGame inherits from class Game
    public class TwentyOneGame : Game
    {
        //implementing abstract method in inheriting class with "override"
        public override void Play()
        {
            //throwing an error when method is called
            throw new NotImplementedException();
        }
        public override void ListPLayers()
        {
            Console.WriteLine("21 Players: ");
            //this auto pops up and is the same as the foreach loop in "Game" class
            base.ListPLayers();


        }
    }
}

