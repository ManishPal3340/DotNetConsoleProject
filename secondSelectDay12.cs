using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
class secondSelectDay12
{
    public static void Main(string[] args)
    {
        var name = new List<string>()
        {
            "ram","Shyam","Mohan"
        };
        // TO UPPERCASE 
        var upperNames= name.Select(n=>n.ToUpper()) ;

        foreach (var n in upperNames)
        {
            Console.WriteLine("UPPERCASE" + n);

          
        }
        Console.WriteLine("====================================");

        // lowerCase 
        var name2 = new List<string>()
        {
            "Manish ","Shyam", "YASH"
        };
        var lowerNames = name2.Select(n1 => n1.ToLower());
        foreach (var n1 in lowerNames) 
            { 
            Console.WriteLine("lowerCase" + n1);
           
        }

        Console.WriteLine("\n====================================");

        // orderBy & OrderDecending

        var name3 = new List<string>()
        {
            "Shriya", "NEHA","Ankita"


        };
        //var name4 = new List<string>()
        var sorted = name3.OrderBy(n2 => n2);

            foreach (var n3 in sorted)
        {
            Console.WriteLine("sorted" + n3);

           
        }
        Console.WriteLine("\n====================================");



        // DECendiong order
        var name4 = new List<string>()
            {
                 "Shriya", "NEHA","Ankita","Manish ","Shyam", "YASH"
            };

        var desc=name4.OrderByDescending(n4 => n4);

        foreach (var n4 in desc)
        {
            Console.WriteLine(" DECendiong order" + n4);

           

        }
        Console.WriteLine("\n====================================");

        // Assending Order

        var name5 = new List<string>()
        {
             "Shriya", "NEHA","Ankita","Manish ","Shyam", "YASH"
        };

        var asc = name4.OrderBy(n5 => n5);

        foreach (var n5 in asc)
        {
            Console.WriteLine("Assending Order" + n5);
           

        }
        Console.WriteLine("\n====================================");


        // REmove Data

        var name6 = new List<string>()
        {
             "Shriya", "NEHA","Ankita","Manish ","Shyam", "YASH"
        };


       name6.RemoveAll(n=>n.StartsWith("S"));

        foreach (var n6 in name6)
        {
            Console.WriteLine("REmove Data" + n6);
           


        }
        Console.WriteLine("\n====================================");

        // Sinlge Item Remove
        var name7 = new List<string>()
        {
             "Shriya", "NEHA","Ankita","Manish ","Shyam", "YASH"
        };

        name7.Remove("Shriya");
        foreach (var n7 in name7)
        {
            Console.WriteLine("Sinlge Item Remove" + n7);
          
        }
        Console.WriteLine("\n====================================");


        // RemoveAt(index)

        var name8 = new List<string>()
        {
            "Shriya", "NEHA","Ankita","Manish ","Shyam", "YASH"
        };
        name8.RemoveAt(3);

        foreach (var n8 in name8)
        {
            Console.WriteLine("RemoveAt(index" + n8);

          

        }
        Console.WriteLine("\n====================================");

        // REmove Range

        var name9 = new List<string>()
        {
             "Shriya", "NEHA","Ankita","Manish ","Shyam", "YASH"
        };

        name9.RemoveRange(1, 4);

        foreach (var n9 in name9)
        {
            Console.WriteLine("RemoveRange" + n9);

           

        }
        Console.WriteLine("\n====================================");

    }
}