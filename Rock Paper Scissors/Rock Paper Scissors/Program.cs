using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
           
            bool playAgin = true;

            while (playAgin)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {

                    Console.Write("Choose between rock, paper  and  scissors:      ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "Rock";
                            Console.WriteLine("computer choose rock");
                            if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (inputPlayer == "paper")
                            {
                                Console.WriteLine("Player wins!!\n\n");
                                scorePlayer++;

                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("Cmputer wins!!\n\n");
                                scoreCPU++;

                            }

                            break;

                        case 2:
                            inputCPU = "Paper";
                            Console.WriteLine("computer choose rock");
                            if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (inputPlayer == "paper")
                            {
                                Console.WriteLine("Player wins!!\n\n");
                                scorePlayer++;

                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("Cmputer wins!!\n\n");
                                scoreCPU++;

                            }
                            break;

                        case 3:
                            inputCPU = "Scissors";
                            Console.WriteLine("computer choose rock");
                            if (inputPlayer == "Rock")
                            {
                                Console.WriteLine("Draw!!\n\n");
                            }
                            else if (inputPlayer == "paper")
                            {
                                Console.WriteLine("Player wins!!\n\n");
                                scorePlayer++;

                            }
                            else if (inputPlayer == "Scissors")
                            {
                                Console.WriteLine("Cmputer wins!!\n\n");
                                scoreCPU++;

                            }
                            break;

                        default:
                            Console.WriteLine("Invalid entry");
                            break;

                    }
                    Console.WriteLine("\n\nScores: Player:\n(n)\tCPU:\n(3)",scorePlayer,scoreCPU);
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player wins");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("computer wins");
                }
                else
                {
                    Console.WriteLine("Do you want to play again?(y\n)");
                    string loop = Console.ReadLine();
                    if (loop == "Y")
                    {
                        playAgin = true;
                        Console.Clear();
                    }
                    else if (loop == "N")
                    {
                        playAgin = false;
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}

