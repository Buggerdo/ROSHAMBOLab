﻿namespace ROSHAMBO
{
    public abstract class Player
    {

        private string _name;

        public string Name { get { return _name; } set { _name = value; } }

        public abstract Roshambo GenerateRoshambo();
    }
}
