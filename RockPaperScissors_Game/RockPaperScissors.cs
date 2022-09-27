﻿using System;

namespace RockPaperScissors_Game
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            // INPUTS
            //Constants
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            //Welcoming messages and prompts for user input
            Console.WriteLine("Hello! Welcome to the \"Rock, paper, scissors\" game!");
            Console.Write("Please enter your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"{playerName}, you will be playing against the computer. Lets start...");
            Console.Write("Your choice: [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine();
            
            // SOLUTION
            //Player moves
            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = Rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = Paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = Scissors;
            }
            else
            {
                Console.WriteLine("Invalid input! Try again: ");
                return;
            }

            //Generating random computer moves
            Random random = new Random();
            int computerRandomNumber = random.Next(1,4);
            string computerMove = "";
            
            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = Rock;
                    break;
                case 2:
                    computerMove = Paper;
                    break;
                case 3:
                    computerMove = Scissors;
                    break;
            }

            // OUTPUT
            //Makes comparison of the both moves and decides who wins or if the game is a draw
            //Prints message with the outcome
            if (playerMove == Rock && computerMove == Rock ||
                playerMove == Paper && computerMove == Paper ||
                playerMove == Scissors && computerMove == Scissors)
            {
                Console.WriteLine($"You and computer choose: {playerMove}. This game is a draw.");
            }
            else if (playerMove == Rock && computerMove == Scissors ||
                playerMove == Paper && computerMove == Rock ||
                playerMove == Scissors && computerMove == Paper)
            {
                Console.WriteLine($"{playerName}, you win! Computer choose {computerMove}.");
            }
            else if (playerMove == Rock && computerMove == Paper ||
                playerMove == Paper && computerMove == Scissors ||
                playerMove == Scissors && computerMove == Rock)
            {
                Console.WriteLine($"Sorry {playerName}, computer wins with {computerMove}!");
            }
        }
    }
}
