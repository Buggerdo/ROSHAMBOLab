namespace ROSHAMBO
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer()
        {
            do
            {
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
            throw new NotImplementedException();
        }
    }
}
