using System;


class Student
{
    public string Name;
    public int Age;


    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void show()
    {
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Age : " + Age);
    }
}

class ParameterizedExample
{
    public static void Main(string[] args)
    {
        Student s1 = new Student("Manish", 22);
        s1.show();
    }
}