using System;

public class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age, string email)
    {
        this.Age = age;
        this.Name = name;
        this.Email = email;
    }

    public Person(string name, int age) : this(name, age, null)
    {
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The name is invalid!");
            }
            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentOutOfRangeException("The age has to be in range [1...100]");
            }
            this.age = value;
        }
    }

    public string Email
    {
        get { return this.email; }
        set
        {
            if(value != null && (value.Length == 0 || !value.Contains("@")))
            {
                throw new ArgumentException("The email is invlaid!");
            }
            this.email = value;
        }
    }

    public override string ToString()
    {
        return string.Format("name: {0}, age: {1}", this.Name, this.Age) +
               (this.Email == null ? "" : ", email: " + this.Email);
    }
}

class Persons
    {
        static void Main()
        {
            Person ginka = new Person("Ginka",30);
            Console.WriteLine(ginka);
            Person gosho = new Person("Gosho",25,"gosho@gmail.com");
            Console.WriteLine(gosho);
        }
    }
