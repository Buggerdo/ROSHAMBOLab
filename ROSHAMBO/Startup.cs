namespace ROSHAMBO
{
    public static class Startup
    {
        public static void StartGame()
        {
            HumanPlayer humanPlayer = new();

            Player otherPlayer = Validator.GetOtherPlayer();

            Roshambo play = humanPlayer.GenerateRoshambo();

            Console.WriteLine(play);
            Console.WriteLine(otherPlayer.Name);
            Console.WriteLine("startup end");
            Console.ReadKey();
        }
    }
}