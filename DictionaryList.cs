using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(1, "Manish");
        students.Add(2, "Rahul");

        foreach (var s in students)
        {
            Console.WriteLine(s.Key + " : " + s.Value);
        }
    }
}


//DictionaryList



