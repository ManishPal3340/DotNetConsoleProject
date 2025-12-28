using System;


// abstract  Class
abstract class OnlineExam
{

    // abstract meethod( login hiden)
    public abstract void CalculateResult(int marks);

    // normal method
    public void ExamInfo()
    {
        Console.WriteLine("Exam Online Assessment");
        Console.WriteLine("total Marks: 100");

    }

}
// child class

class Result: OnlineExam
{
    public override void CalculateResult(int marks)
    {
        if (marks >= 40)
            Console.WriteLine("Result: PASS");
        else
            Console.WriteLine("Result: FAIL");
    }
}
class AbtractionExample
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter Studewnt Marks");
        string name=Console.ReadLine();

        Console.WriteLine();
        int marks =Convert.ToInt32(Console.ReadLine());


        OnlineExam exam = new Result();
        exam.ExamInfo();
        Console.WriteLine("Student Name: " + name);
        exam.CalculateResult(marks);
    }
}