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
        int Player1Score;
        int Player2Score;

        //constructor
        public GameMechanics()
        {
            
        }
        //member methods
        public void ExplainGame()
        {
            Console.WriteLine("Rock paper scissors lizard Spock! Regular RPS, with addition of Lizard, and Spock. \n (Lizard beats paper and Spock, while Spock beats rock and scissors.)");
        }
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
            Console.WriteLine("Player 1 picked " + Player1Choice +", and Player 2 Picked " + Player2Choice + ".");
            

            switch (PlayersChoices)
            {
                case "RockPaper":
                    Console.WriteLine("Player 2 wins!");
                    Player2Score ++;
                    break;

                case "RockScissors":
                    Console.WriteLine("Player 1 wins!");
                    Player1Score++;
                    break;

                case "RockLizard":
                    Console.WriteLine("Player 1 wins!");
                    Player1Score++;
                    break;

                case "RockSpock":
                    Console.WriteLine("Player 2 wins!");
                    Player2Score++;
                    break;

                case "PaperRock":
                    Console.WriteLine("Player 1 wins!");
                    Player1Score++;
                    break;

                case "PaperScissors": 
                    Console.WriteLine("Player 2 wins!");
                    Player2Score++;
                    break;

                case "PaperLizard": 
                    Console.WriteLine("Player 2 wins!");
                    Player2Score++;
                    break;

                case "PaperSpock": 
                    Console.WriteLine("Player 1 wins!");
                    Player1Score++;
                    break;

                case "ScissorsRock": 
                    Console.WriteLine("Player 2 wins!");
                    Player2Score++;
                    break;

                case "ScissorsPaper":
                    Console.WriteLine("Player 1 wins!");
                    Player1Score++;
                    break;

                case "ScissorsLizard":
                    Console.WriteLine("Player 1 wins!");
                    Player1Score++;
                    break;

                case "ScissorsSpock":
                    Console.WriteLine("Player 2 wins!");
                    Player2Score++;
                    break;

                case "LizardRock": 
                    Console.WriteLine("Player 2 wins!");
                    Player2Score++;
                    break;

                case "LizardPaper":
                    Console.WriteLine("Player 1 wins!");
                    Player1Score++;
                    break;

                case "LizardScissors":
                    Console.WriteLine("Player 2 wins!");
                    Player2Score++;
                    break;

                case "LizardSpock":
                    Console.WriteLine("Player 1 wins!");
                    Player1Score++;
                    break;

                case "SpockRock":
                    Console.WriteLine("Player 1 wins!");
                    Player1Score++;
                    break;

                case "SpockPaper":
                    Console.WriteLine("Player 2 wins!");
                    Player2Score++;
                    break;

                case "SpockScissors":
                    Console.WriteLine("Player 1 wins!");
                    Player1Score++;
                    break;

                case "SpockLizard":
                    Console.WriteLine("Player 2 wins!");
                    Player2Score++;
                    break;

                case "RockRock":
                    Console.WriteLine("Draw! Try again!");
                    StartPlaying();
                    break;

                case "PaperPaper":
                    Console.WriteLine("Draw! Try again!");
                    StartPlaying();
                    break;
                
                case "ScissorsScissors":
                    Console.WriteLine("Draw! Try again!");
                    StartPlaying();
                    break;

                case "SpockSpock":
                    Console.WriteLine("Draw! Try again!");
                    StartPlaying();
                    break;

                case "LizardLizard":
                    Console.WriteLine("Draw! Try again!");
                    StartPlaying();
                    break;

                default:
                    break;

            }
        }
        public void KeepScore()
        {

            while(Player2Score != 2 && Player1Score != 2)
            {
                StartPlaying();
            }


        }
        public void ProclaimVictor()
        {
            if(Player1Score == 2){
                Console.WriteLine("Player 1 is victorous!");
            }
            else
            {
                Console.WriteLine("Player 2 is victorious!");
            }
        }
        }
    }

