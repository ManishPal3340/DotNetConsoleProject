using System;

// Interface
interface IHospitalService
{
    void RegisterPatient(string name);
    void CalculateBill(double amount);
}

// Class implementing interface
class Hospital : IHospitalService
{
    public void RegisterPatient(string name)
    {
        Console.WriteLine("Patient Registered Successfully");
        Console.WriteLine("Patient Name: " + name);
    }

    public void CalculateBill(double amount)
    {
        double gst = amount * 0.05;
        double total = amount + gst;

        Console.WriteLine("Treatment Cost: " + amount);
        Console.WriteLine("GST (5%): " + gst);
        Console.WriteLine("Total Bill: " + total);
    }
}
class AbtractionExampleInterface
{
    public static void Main(string[] args)
    {

        Console.Write("Enter Patient Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Treatment Cost: ");
        double cost = Convert.ToDouble(Console.ReadLine());

        IHospitalService hospital = new Hospital();

        hospital.RegisterPatient(name);
        hospital.CalculateBill(cost);
    }
}
