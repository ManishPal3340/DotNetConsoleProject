using System;
using System.Linq;
using System.Collections.Generic;
class Day12First
{
    public static void Main(string[] args)
    {
        List<int> number = new List<int>()
        {
            1,3,4,6,7,8,4,9,9,0,64,3,2,5,2,56,7,8,6,4,3,36,7,8,76
        };

        var result = number.Where(n => n > 10);
        foreach(var n in result )
            Console.WriteLine(n);
    }
}