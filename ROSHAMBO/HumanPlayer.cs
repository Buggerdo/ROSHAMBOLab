namespace ROSHAMBO
{
    public class HumanPlayer : Player
    {
        public HumanPlayer()
        {
            do
            {
                Console.Clear();
                Console.Write("Please enter your name: ");
                string input = Console.ReadLine();
                if(!String.IsNullOrEmpty(input))
                {
                    Name = input;
                    return;
                } 
            } while(true);
        }
        public override Roshambo GenerateRoshambo()
        {
            return Validator.GetPlayerRoshamo();
        }
    }
}
