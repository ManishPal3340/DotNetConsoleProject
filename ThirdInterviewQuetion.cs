using System;

class Test
{
    public const int A = 10;
    public readonly int B;

    public Test()
    {
        B = 20;
    }
}

class ThirdInterviewQuetion
{
    static void Main()
    {
        Test t = new Test();
        Console.WriteLine(Test.A);
        Console.WriteLine(t.B);
    }
}
