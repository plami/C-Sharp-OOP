namespace Animals
{
    public class Kitten :Cat
    {
        public Kitten(string name, int age)
            : base(name, age, Gender.Femail)
        {
            
        }

        public override string ToString()
        {
            return string.Format("I am {0} cat", this.Gender.ToString().ToLower());
        }
    }
}