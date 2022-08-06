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

                Roshambo play = humanPlayer.GenerateRoshambo(); 

            } while(Validator.Continue());

            Console.WriteLine("startup end");
            Console.ReadKey();
        }
    }
}