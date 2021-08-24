using System;
using System.Collections.Generic;
namespace Rock__Paper____Scissors {
    class Program {
        static void Main(string[] args) {
            Console.Title = "Rock, Paper, Scissors, Shoot";
            int playerWinStreak = 0;
            int playerLoseStreak = 0;
            int drawMatchNumber = 0;
            while (true) {
                string[] threeChoice = {"Rock","Paper","Scissors"};
                Random numberGen = new Random();
                Console.WriteLine("Type \"q\" to quit");
                Console.WriteLine("Type to pick:\nRock\nPaper\nScissors");
                string playerMove = Console.ReadLine();
                Console.WriteLine($"Player move: {playerMove}");
                string computerMove = threeChoice[numberGen.Next(3)];
                Console.WriteLine($"Computer move: {computerMove}");
                if (playerMove == "Rock" && computerMove == "Scissors") {
                    playerWin();
                } else if (playerMove == "Paper" && computerMove == "Rock") {
                    playerWin();
                } else if (playerMove == "Scissors" && computerMove == "Paper") {
                    playerWin();
                } else if (playerMove == "Rock" && computerMove == "Paper") {
                    playerLose();
                } else if (playerMove == "Paper" && computerMove == "Scissors") {
                    playerLose();
                } else if (playerMove == "Scissors" && computerMove == "Rock") {
                    playerLose();
                } else if (playerMove == "Rock" && computerMove == "Rock") {
                    drawMatch();
                } else if (playerMove == "Scissors" && computerMove == "Scissors") {
                    drawMatch();
                } else if (playerMove == "Paper" && computerMove == "Paper") {
                    drawMatch();
                } else if (playerMove == "q") {
                    quitGame();
                }
                void playerWin() {
                    Console.WriteLine("You win");
                    playerWinStreak++;
                    Console.ReadKey();
                }
                void playerLose() {
                    Console.WriteLine("You lose");
                    playerLoseStreak++;
                    Console.ReadKey();
                }
                void drawMatch() {
                    Console.WriteLine("Draw");
                    drawMatchNumber++;
                    Console.ReadKey();
               }
               Console.WriteLine($"Score: {playerWinStreak} wins, {playerLoseStreak} loses, {drawMatchNumber} draws");
            }
        }
        static void quitGame() {
            System.Environment.Exit(0);
        }
    }
}
// dumbass polish the code and add a loop system and something to keep track of wins and losses
// asshole i did it
