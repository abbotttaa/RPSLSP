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
        Player Player2;
        Player Player1;
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
                    Player1 = new HumanPlayer();
                    Player2 = new ComputerPlayer();
                    break;
                case "Person":
                    Player1 = new HumanPlayer();
                    Player2 = new HumanPlayer();
                    break;
                default:
                    Console.WriteLine("Dummy! Do it right this time! >:^(");
                    ChooseYourChallenger();
                    break;
            }
        }

        public void StartPlaying()
        {
            string Player1Choice = Player1.MakeChoice();
            string Player2Choice = Player2.MakeChoice();
            string PlayersChoices = Player1Choice + Player2Choice;
            

            switch (PlayersChoices)
            {
                case "RockPaper":
                    Console.WriteLine("Player 2 wins!");
                    break;

                case "RockScissors":
                    Console.WriteLine("Player 1 wins!");
                    break;

                case "RockLizard":
                    Console.WriteLine("Player 1 wins!");
                    break;

                case "RockSpock":
                    Console.WriteLine("Player 2 wins!");
                    break;

                case "PaperRock":
                    Console.WriteLine("Player 1 wins!");
                    break;

                case "PaperScissors": 
                    Console.WriteLine("Player 2 wins!");
                    break;

                case "PaperLizard": 
                    Console.WriteLine("Player 2 wins!");
                    break;

                case "PaperSpock": 
                    Console.WriteLine("Player 1 wins!");
                    break;

                case "ScissorsRock": 
                    Console.WriteLine("Player 2 wins!");
                    break;

                case "ScissorsPaper":
                    Console.WriteLine("Player 1 wins!");
                    break;

                case "ScissorsLizard":
                    Console.WriteLine("Player 1 wins!");
                    break;

                case "ScissorsSpock":
                    Console.WriteLine("Player 2 wins!");
                    break;

                case "LizardRock": 
                    Console.WriteLine("Player 2 wins!");
                    break;

                case "LizardPaper":
                    Console.WriteLine("Player 1 wins!");
                    break;

                case "LizardScissors":
                    Console.WriteLine("Player 2 wins!");
                    break;

                case "LizardSpock":
                    Console.WriteLine("Player 1 wins!");
                    break;

                case "SpockRock":
                    Console.WriteLine("Player 1 wins!");
                    break;

                case "SpockPaper":
                    Console.WriteLine("Player 1 wins!");
                    break;

                case "SpockScissors":
                    Console.WriteLine("Player 1 wins!");
                    break;

                case "SpockLizard":
                    Console.WriteLine("Player 1 wins!");
                    break;

                case "RockRock":
                    Console.WriteLine("Draw! Try again!");
                    break;

                case "PaperPaper":
                    Console.WriteLine("Draw! Try again!");
                    break;
                
                case "ScissorsScissors":
                    Console.WriteLine("Draw! Try again!");
                    break;

                case "SpockSpock":
                    Console.WriteLine("Draw! Try again!");
                    break;

                case "LizardLizard":
                    Console.WriteLine("Draw! Try again!");
                    break;

                default:
                    break;

            }
            Console.ReadLine();
        }
        }
    }

