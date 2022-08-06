namespace ROSHAMBO
{
    internal class RandomPlayer : Player
    {
        public RandomPlayer()
        {
            Name = "Randy Random";
        }

        public override Roshambo GenerateRoshambo()
        {
            Random rand = new();
            int randInt = rand.Next(3);
            return (Roshambo)randInt;
        }
    }
}
