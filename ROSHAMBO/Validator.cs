﻿
namespace ROSHAMBO
{
    public static class Validator
    {
        public static Player GetOtherPlayer()
        {
            RockPlayer rockPlayer = new();
            RandomPlayer randomPlayer = new();
            do
            {
                Console.Clear();
                Console.WriteLine("Who would you like to play,");
                Console.WriteLine($"1: {randomPlayer.Name}");
                Console.WriteLine($"2: {rockPlayer.Name}");
                string userInput = Console.ReadLine().ToLower().Trim();
                if(String.IsNullOrEmpty(userInput))
                {
                    continue;
                }
                else if(randomPlayer.Name.ToLower().StartsWith(userInput) || userInput == "1")
                {
                    Console.WriteLine($"You choose {randomPlayer.Name}!!");
                    return randomPlayer;
                }
                else if(rockPlayer.Name.ToLower().StartsWith(userInput) || userInput == "2")
                {
                    Console.WriteLine($"You choose {rockPlayer.Name}!!");
                    return rockPlayer;
                }
            } while(true);
        }

        public static Roshambo GetPlayerRoshamo()
        {
            do
            {
                Console.Clear();
                Console.Write($"Please choose {Roshambo.rock},  {Roshambo.paper} or {Roshambo.scissors}: ");
                string userInput = Console.ReadLine().ToLower().Trim();
                if(String.IsNullOrEmpty(userInput))
                {
                    continue ;
                }
                else if(Roshambo.rock.ToString().ToLower().StartsWith(userInput))
                {
                    return Roshambo.rock;

                }else if(Roshambo.paper.ToString().ToLower().StartsWith(userInput))
                {
                    return Roshambo.paper;
                }
                else if(Roshambo.scissors.ToString().ToLower().StartsWith(userInput))
                {
                    return Roshambo.scissors;
                }
            } while(true);
        }
    }
}