using System;

class Student
{
    public string Name;
    public int Age;

    public void Display()// values Display
    {
        Console.WriteLine("Name : "+ Name);
        Console.WriteLine("Age : "+ Age );
    }
}
class Program
{
    static void Main(string[] args)
    {
        // create aobject
        Student s1=new Student();
        s1.Name = "Manish";
        s1.Age = 20;
        s1.Display();
    }
}