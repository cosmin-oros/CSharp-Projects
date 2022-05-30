using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Math;

namespace RockPaperScissors{
    class Program{
        static void Main(string[] args){
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;
            
            while(scorePlayer < 3 && scoreCPU < 3){

            Console.WriteLine("Choose between ROCK, PAPER, SCISSORS: ");
            inputPlayer = Console.ReadLine();

            Random rnd = new Random();

            randomInt = rnd.Next(1,4);

            switch(randomInt){
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer chose ROCK");
                    if(inputPlayer == "ROCK"){
                        Console.WriteLine("DRAW");
                    }else if(inputPlayer == "SCISSORS"){
                        Console.WriteLine("LOSS");
                        scoreCPU++;
                    }else{
                        Console.WriteLine("WIN");
                        scorePlayer++;
                    }
                    break;
                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer chose PAPER");
                    if(inputPlayer == "PAPER"){
                        Console.WriteLine("DRAW");
                    }else if(inputPlayer == "ROCK"){
                        Console.WriteLine("LOSS");
                        scoreCPU++;
                    }else{
                        Console.WriteLine("WIN");
                        scorePlayer++;
                    }
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    Console.WriteLine("Computer chose SCISSORS");
                    if(inputPlayer == "SCISSORS"){
                        Console.WriteLine("DRAW");
                    }else if(inputPlayer == "PAPER"){
                        Console.WriteLine("LOSS");
                        scoreCPU++;
                    }else{
                        Console.WriteLine("WIN");
                        scorePlayer++;
                    }
                    break;
                default:
                    break;

            }

            }

            if(scorePlayer == 3){
                Console.WriteLine("Player won!");
            }else if(scoreCPU == 3){
                Console.WriteLine("CPU won!");
            }
            Console.WriteLine();

        }
    }
}