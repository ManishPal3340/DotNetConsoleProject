using System;

class Vehicle  // Parent Class
{
    protected string brand;
    protected int speed;


    public void SetVehicleDetails(string brandName, int maxSpeed)
    {
        brand = brandName;
        speed = maxSpeed;
    }
    public void ShowDetails()
    {
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Max Speed: " + speed + " km/h");

    }
}

class Car: Vehicle
{
    public void CarType()
    {
        Console.WriteLine("This is a Car");
    }
}

class InheritanceExample
{
    public static void Main(string[] args)
    {
        Car car = new Car();

        car.SetVehicleDetails("Honda", 180);
        car.CarType();
        car.ShowDetails();

    } 
}