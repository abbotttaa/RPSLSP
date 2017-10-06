using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazinglebazgo
{
    class GameMechanics
    {
        //member variables
        MatchUpChart comparisons = new MatchUpChart();
        Player Player2;
        Player Player1 = new Player();
        //constructor
        public GameMechanics()
        {
            
        }
        //member methods
        public void ChooseYourChallenger()
        {
            Console.WriteLine("Are you playing with another person, or agaisnt the computer? Please enter \"Computer\" or \"Person\"");
            string Choice = Console.ReadLine();
                switch (Choice)
            {
                case "Computer":
                    Player2 = new ComputerPlayer();
                    break;
                case "Person":
                    Player2 = new HumanPlayer();
                    break;
                default:
                    Console.WriteLine("Dummy! Do it right this time! >:^(");
                    ChooseYourChallenger();
                    break;
            }
        }

        public void round()
        {
            Player1.MakeChoice();
            Player2.MakeChoice();
            comparisons.MatchUpWinner();
        }
    }
}
