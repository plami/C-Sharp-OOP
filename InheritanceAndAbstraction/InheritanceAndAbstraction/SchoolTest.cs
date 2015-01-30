using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace InheritanceAndAbstraction
{
    class SchoolTest
    {
        static void Main()
        {
            IList<Student> students = new List<Student>
            {
                new Student("Georgi Georgiev",3),
                new Student("Ani Kostova",1),
                new Student("Ivan Ivanov",4),
                new Student("Boris Ivanov",2)
            };

            var Csharp = new Discipline("C#", 10);
            Csharp.AddStudent(students[0]);
            Csharp.AddStudent(students[3]);
            Csharp.Details = "OOP";

            var Unity = new Discipline("Unity 3D", 14);
            Unity.AddStudent(students[0]);
            Unity.AddStudent(students[1]);
            Unity.AddStudent(students[2]);
            Unity.AddStudent(students[3]);
            Unity.Details = "Fast-Track course";

            var java = new Discipline("Java", 8);
            java.AddStudent(students[1]);
            java.AddStudent(students[2]);
            java.AddStudent(students[3]);

            var JavaScript = new Discipline("JavaScript", 5);
            JavaScript.AddStudent(students[0]);
            JavaScript.AddStudent(students[3]);

            var teacher1 = new Teacher("Georgi Stefanov");
            teacher1.AddDiscipline(Unity);
            teacher1.AddDiscipline(java);

            var teacher2 = new Teacher("Stancho Kolev");
            teacher2.AddDiscipline(JavaScript);
            teacher2.AddDiscipline(Csharp);

            var Class = new Class("A", new List<Teacher>{teacher1, teacher2}, "additional class");

            string str = Class.ToString();
            Console.WriteLine(Class);
        }
    }
}
