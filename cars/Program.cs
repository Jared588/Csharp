// See https://aka.ms/new-console-template for more information

Car car1 = new Car("Ford", "Mustang", 2022, "Red");
Car car2 = new Car("Chevy", "Corvette", 2020, "Blue");

car1.Drive();
car2.Drive();

class Car 
{
    string make;
    string model;
    int year;
    string color;

    public Car(string make, string model, int year, string color)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
    }

    public void Drive()
    {
        Console.WriteLine($"You drive a {color} {make}, {model} ({year})");
    }

}
