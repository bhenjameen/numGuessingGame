using System;
using System.Threading;
namespace numberGuessingGame {
    class Program {
        static void Main (string[] args) {
            //C# Number Guessing Game written by Benjamin Patrick EYOH (Bhenjameen)

            //Declare Variables
            string name = "";
            string level = "";
            int maxTries = 0;
            string start = "";
            int min = 0;
            int max = 0;
            //int remTries = 0;
            int gameOver = 1;

            Console.Write ("\n\nWelcome to Number Guessing Game. \n\nEnter your name please:-  ");
            name = Console.ReadLine ();

            Thread.Sleep (800);
            Console.WriteLine ("\n...");
            Thread.Sleep (800);
            Console.Write ("Hello " + name + " \nChoose your difficulty level\n\n");
            Thread.Sleep (800);
            Console.WriteLine ("...");

            //Highlight and explain levels of the game
            Console.WriteLine ("easy:     (Guess between 1 and 10 with 6 guesses)");
            Console.WriteLine ("medium:   (Guess between 1 and 20 with 4 guesses)");
            Console.WriteLine ("hard:     (Guess between 1 and 50 with 3 guesses)\n");

            //User is able to set the level they want to play
            Console.Write ("Type your level and press 'ENTER' to continue:-  ");
            level = Console.ReadLine ();
            Console.WriteLine ();

            if (level == "hard") {
                maxTries = 3;
                min = 1;
                max = 50;
            } else if (level == "medium") {
                maxTries = 4;
                min = 1;
                max = 20;
            } else if (level == "easy") {
                maxTries = 6;
                min = 1;
                max = 10;
            }

            Thread.Sleep (800);
            Console.WriteLine ("...");
            Console.WriteLine ("You chose " + level + " level");
            Console.WriteLine ("You have " + maxTries + " guesses");

            Thread.Sleep (800);
            Console.WriteLine ("...");
            Console.WriteLine ("Press 'ENTER' to start");
            start = Console.ReadLine ();

            //Game starts
            while (maxTries > 0) {
                Random random = new Random ();
                int magicNumber = random.Next (min, max + 1);

                Console.Write ("\nI am thinking of a number between " + min + " and " + max + ". \nGuess the number :   ");
                string guessAsString = Console.ReadLine ();
                int guess = -1;

                //Integer input validation and win and lose declarations
                if (int.TryParse (guessAsString, out guess)) {
                    if (guess == magicNumber) {
                        Console.WriteLine ("\nYou got it right");
                        break;
                    } else if (maxTries <= gameOver) {
                        Console.WriteLine ("\nThat was wrong. \nYou are out of chances. \nGame Over!!! You Lose.");
                        break;
                    } else {
                        maxTries -= 1;
                        Console.WriteLine ("\nThat was wrong, try again");
                        Console.WriteLine ("You have " + maxTries + " guess(es) left");
                    }
                } else {
                    Console.WriteLine ("\nThat is not a number. \nPlease check your input and ensure it is a number");
                }
            }

        }

    }

}