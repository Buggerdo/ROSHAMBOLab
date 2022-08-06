namespace ROSHAMBO
{
    public class RockPlayer : Player
    {
        public RockPlayer()
        {
            Name = "The Rock";
        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
