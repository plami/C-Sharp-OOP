using System;

namespace GenericList
{
    class Test
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>(3);
            list.AddElement(4);
            list.AddElement(100);
            list.InsertElement(54, 1);
            list.InsertElement(54, 0);
            list.RemoveElement(0);
            Console.WriteLine(list);
            Console.WriteLine(list.IfContains(0));
            Console.WriteLine(list.Max<int>());
            GenericList<int>.DisplayVersion();
        }
    }
}
