
namespace ROSHAMBO
{
    public static class Validator
    {
        public static Player GetOtherPlayer(RockPlayer rockPlayer, RandomPlayer randomPlayer)
        {

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

        internal static void CompairThrows(Roshambo humanThrow, Roshambo otherThrow)
        {
            string win = "You win!";
            string lose = "You lose.";
            string draw = "It's a draw.";
            switch(humanThrow)
            {
                case Roshambo.rock:
                    if(otherThrow == Roshambo.paper)
                    {
                        Console.WriteLine(lose);
                        break;
                    }
                    else if(otherThrow == Roshambo.scissors)
                    {
                        Console.WriteLine(win);
                        break;
                    }
                    Console.WriteLine(draw);
                    break;
                case Roshambo.paper:
                    if(otherThrow == Roshambo.paper)
                    {
                        Console.WriteLine(draw);
                        break;
                    }
                    else if(otherThrow == Roshambo.scissors)
                    {
                        Console.WriteLine(lose);
                        break;
                    }
                    Console.WriteLine(win);
                    break;
                case Roshambo.scissors:
                    if(otherThrow == Roshambo.paper)
                    {
                        Console.WriteLine(win);
                        break;
                    }
                    else if(otherThrow == Roshambo.scissors)
                    {
                        Console.WriteLine(draw);
                        break;
                    }
                    Console.WriteLine(lose);
                    break;
                default:
                    break;
            }
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
                else if(Roshambo.rock.ToString().StartsWith(userInput))
                {
                    return Roshambo.rock;

                }else if(Roshambo.paper.ToString().StartsWith(userInput))
                {
                    return Roshambo.paper;
                }
                else if(Roshambo.scissors.ToString().StartsWith(userInput))
                {
                    return Roshambo.scissors;
                }
            } while(true);
        }

        public static bool Continue()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            do
            {
                Console.Clear();
                Console.Write("Would you like to continue Y/N?");
                string userInput = Console.ReadLine().ToLower().Trim();
                if(String.IsNullOrEmpty(userInput))
                {
                    continue;
                }
                else if("yes".StartsWith(userInput))
                {
                    return true;
                }
                else if("no".StartsWith(userInput))
                {
                    return false;
                }
            } while(true);
        }
    }
}
