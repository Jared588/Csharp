// See https://aka.ms/new-console-template for more information
// Simple calculator

double num1 = 0;
double num2 = 0;
double result = 0;

do {

    Console.WriteLine("==========");
    Console.WriteLine("Calculator");
    Console.WriteLine("==========");

    Console.Write("Enter number 1: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter number 2: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter an option: ");
    Console.WriteLine("\t+ : Add");
    Console.WriteLine("\t- : Subtract");
    Console.WriteLine("\t* : Multiply");
    Console.WriteLine("\t/ : Divide");

    switch (Console.ReadLine())
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine($"Your result: {num1} + {num2} = " + result);
            break;
        case "-":
            result = num1 - num2;
            Console.WriteLine($"Your result: {num1} - {num2} = " + result);
            break;
        case "*":
            result = num1 * num2;
            Console.WriteLine($"Your result: {num1} * {num2} = " + result);
            break;
        case "/":
            result = num1 / num2;
            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
            break;
        default:
            Console.WriteLine("Invalid Response");
            break;
    }
    Console.WriteLine("Exit? (y/n)");
} while (Console.ReadLine().ToLower() == "n");

Console.WriteLine("Bye!");