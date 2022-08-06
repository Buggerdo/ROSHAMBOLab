namespace ROSHAMBO
{
    public abstract class Person
    {

        private string _name;

        public string Name { get { return _name; } set { _name = value; } }

        public abstract Roshambo GenerateRoshambo();
    }
}
