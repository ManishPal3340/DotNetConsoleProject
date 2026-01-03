
    using System;

class usingTRyCAtchExample4
{
    static void Main()
    {
        try
        {
            int[] arr = new int[2];
            arr[5] = 10;
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of range");
        }
        catch (Exception)
        {
            Console.WriteLine("General exception");
        }
    }
}
