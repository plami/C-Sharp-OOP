using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    class Test
    {
        static void Main()
        {
            IList<Animal> animals = new List<Animal>
        {
            new Dog("Sharo", 2, Gender.Male),
            new Cat("Pisana", 4, Gender.Femail),
            new Frog("Jabcho", 1, Gender.Male),
            new Frog("Jabka", 3, Gender.Femail),
            new Kitten("Vasilka", 6),
            new Tomcat("Tom", 8),
        };

            var animalsBygroups = animals.GroupBy(GetAnimalKind,
                (g, a) => new { kind = g, averagAge = a.Average(animal => animal.Age) });

            foreach (var animalGroup in animalsBygroups)
            {
                Console.WriteLine("The average age of {0}s is {1:f2}.", animalGroup.kind, animalGroup.averagAge);
            };
        }

        public static string GetAnimalKind(Animal animal)
        {
            string kind = "";
            if (animal.GetType().BaseType.Name == "Animal")
            {
                kind = animal.GetType().Name;
            }
            else
            {
                kind = animal.GetType().BaseType.Name;
            }

            return kind;
        }
    }
}
