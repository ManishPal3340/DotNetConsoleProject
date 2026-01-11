using System;

// Abstract class
abstract class Animal
{
    public abstract void Sound();

    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping");
    }
}

// Interface
interface IBird
{
    void Fly();
}

// Class using both
class Dog : Animal, IBird
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }

    public void Fly()
    {
        Console.WriteLine("Bird can fly");
    }
}

class firstInterviewQuetion
{
    static void Main()
    {
        Dog d = new Dog();
        d.Sound();
        d.Sleep();
        d.Fly();
    }
}
