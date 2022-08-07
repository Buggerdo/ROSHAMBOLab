namespace ROSHAMBO
{
    public static class Startup
    {
        public static void StartGame()
        {
            RockPlayer rockPlayer = new();
            RandomPlayer randomPlayer = new();
            HumanPlayer humanPlayer = new();
            Player otherPlayer = Validator.GetOtherPlayer(rockPlayer, randomPlayer);

            do
            {

                Roshambo humanThrow = humanPlayer.GenerateRoshambo(); 
                Roshambo otherThrow = otherPlayer.GenerateRoshambo();
                Console.WriteLine($"{humanPlayer.Name}: {humanThrow}");
                Console.WriteLine($"{otherPlayer.Name}: {otherThrow}");
                Validator.CompairThrows(humanThrow, otherThrow);
            } while(Validator.Continue());
            Console.WriteLine("Thank you for playing!");
        }
    }
}