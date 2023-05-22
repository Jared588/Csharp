// See https://aka.ms/new-console-template for more information
//Simple hello world program

Console.Write("What's your name?: ");
String name = Console.ReadLine();

while (name == "")
{
    Console.Write("What's your name?: ");
    name = Console.ReadLine();
}

Console.Write("What's your age?: ");
String age = Console.ReadLine();

while (age == "")
{
    Console.Write("What's your age?: ");
    age = Console.ReadLine();
}

int ageint = Convert.ToInt32(age);

while (ageint < 0)
{
    Console.WriteLine("Age can't be a negative value");
    Console.Write("What's your age?: ");
    age = Console.ReadLine();
    ageint = Convert.ToInt32(age);
}

Console.WriteLine("Hello, " + name + ". Your age is " + ageint);