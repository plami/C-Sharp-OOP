using System;

namespace Animals
{
    ﻿public enum Gender
     {
         Femail,
         Male
     }

    public abstract class Animal : ISound
    {
        private string name;
        private int age;

        protected Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public Gender Gender { get; private set; }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The age cannot be negative or zero!");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("I am {0} {1} and I am {2} years", this.Gender.ToString().ToLower() , this.Name,this.Age);
        }

        public abstract void ProduceSound();
    }
}