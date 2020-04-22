using System;
using System.Security.Cryptography;
using System.Threading;
namespace numberGuessingGame {
    class Program {
        static void Main (string[] args) {
            //C# Number Guessing Game written by Benjamin Patrick EYOH (Bhenjameen)

            string name = "";
            string level = "";
            int maxTries = 0;
            int tries = 0;
            int min = 0;
            int max = 0;
            int remTries = 0;
            bool gameOver = false;

            Console.Write ("\n\nWelcome to Number Guessing Game. \n\nEnter your name please:-  ");
            name = Console.ReadLine ();
            Console.WriteLine ("\n");

            Thread.Sleep (800);
            Console.WriteLine ("...");
            Thread.Sleep (800);
            Console.Write ("Hello " + name + " \nChoose your difficulty level\n\n");

            Thread.Sleep (800);
            Console.WriteLine ("...");
            Thread.Sleep (800);
            Console.WriteLine ("easy:     (Guess between 1 and 10 with 6 guesses)");
            Console.WriteLine ("medium:   (Guess between 1 and 20 with 4 guesses)");
            Console.WriteLine ("hard:     (Guess between 1 and 50 with 3 guesses)\n");
            Console.Write ("Type your level and press 'ENTER' to start:-  ");
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
            } else {
                Console.Write ("Type your level and press 'ENTER' to start:-  ");
                level = Console.ReadLine ();
                Console.WriteLine ();
            }

            Thread.Sleep (800);
            Console.WriteLine ("...");
            Console.WriteLine ("You chose " + level + " level");
            Console.WriteLine ("You have " + maxTries + " guesses");
            Thread.Sleep (800);
            Console.WriteLine ("...");
            Thread.Sleep (800);
            Console.WriteLine ("Press 'ENTER' to start");
            Console.ReadLine ();
            Thread.Sleep (800);
            Console.WriteLine ("...");
            Thread.Sleep (800);
            Console.Write ("I am thinking of a number between " + min + " and " + max + ". \nWhat is the number:   ");
            string guessAsString = Console.ReadLine ();

            Random random = new Random ();
            int magicNumber = random.Next (min, (max + 1));

            while (gameOver == false) {

                remTries = maxTries--;

                int guess = 0;
                if (!int.TryParse (guessAsString, out guess)) {
                    Thread.Sleep (800);
                    Console.WriteLine ("...");
                    Console.WriteLine ("This is not a number. \nPlease input a number");
                    Console.WriteLine ("...");
                    Console.Write ("I am thinking of a number between " + min + " and " + max + ". \nWhat is the number:   ");
                } else if (guess != magicNumber && tries == maxTries) {
                    Thread.Sleep (800);
                    Console.WriteLine ("...");
                    Console.WriteLine ("Game Over!!! \nYou LOSE!!!");
                    gameOver = true;
                } else if (guess == magicNumber) {
                    Thread.Sleep (800);
                    Console.WriteLine ("...");
                    Console.WriteLine ("You got it right. \nCongratulations " + name);
                    gameOver = true;
                } else if (guess != magicNumber) {
                    Thread.Sleep (800);
                    Console.WriteLine ("...");
                    Console.WriteLine ("That was wrong! \nTry again " + name + ". You have " + maxTries + " guesses left");
                    Thread.Sleep (800);
                    Console.WriteLine ("...");
                    Console.Write ("I am thinking of a number between " + min + " and " + max + ". \nWhat is the number:   ");

                }
            }

        }
    }
}