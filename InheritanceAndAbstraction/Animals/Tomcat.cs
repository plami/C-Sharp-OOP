﻿namespace Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Gender.Male)
        {
            
        }

        public override string ToString()
        {
            return string.Format("I am {0} cat", this.Gender.ToString().ToLower());
        }
    }
}