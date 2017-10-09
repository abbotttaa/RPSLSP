using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazinglebazgo
{
    class ComputerPlayer : Player
    {
        
        //member variables
        public int RandomNumber;
        Random random = new Random();
        //constructor
        //member methods
        override public string  MakeChoice()
        {
            int RandomPick = random.Next(1, 5);         
            switch (RandomPick) {
                case 1:
                    return "Rock";
                case 2:
                    return "Paper";
                case 3:
                    return "Scissors";
                case 4:
                    return "Lizard";
                default:
                    return "Spock";
                                 
                
            }
        }            
    }
}
