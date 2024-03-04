using DiceRollGame.UserCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame.Game
{


    public class GuessingGame
    {
        private readonly Dice _dice;

        private const int InitialTries = 3;

        public GuessingGame(Dice dice)
        {
            _dice = dice;

        }

        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine($"Dice rolled. Guess what number it shows in {InitialTries} tries.");

            var triesLeft = InitialTries;
            while (triesLeft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a number:");

                if (guess == diceRollResult)
                {
                    return GameResult.Victory;
                }
                Console.WriteLine("Wrong number.");
                --triesLeft;

            }
            return GameResult.Loss;
        }

        internal static void PrintResult(GameResult gameResult)
        {
            string message = gameResult == GameResult.Victory ? "You win!" : "You Lose!"; ;

            if (gameResult == GameResult.Victory)
            {
                message = "You Win!";
            }
            else
            {
                message = "You Lose";
            }



            Console.WriteLine(message);

        }
    }
}
