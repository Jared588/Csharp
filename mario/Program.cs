// See https://aka.ms/new-console-template for more information

Console.Write("Height: ");
String height = Console.ReadLine();

int x = Convert.ToInt32(height);

for (int i = 0; i < x; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write("#");
        }
        Console.WriteLine();
    }