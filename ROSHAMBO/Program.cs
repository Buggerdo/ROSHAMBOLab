namespace ROSHAMBO
{
    internal class Program
    {
        static void Main()
        {
            Roshambo test = Roshambo.paper;
            Console.WriteLine((int)test);
            int testInt = 0;
            Console.WriteLine((Roshambo)testInt);

            test.ToString();
            Console.WriteLine(test);

            string test2 = "tea";
            Roshambo getProduct;
            bool checkParse = Enum.TryParse(test2, out getProduct);
            Console.WriteLine(checkParse);
            Console.WriteLine(getProduct);
        }
    }
}