// See https://aka.ms/new-console-template for more information

using System.ComponentModel;

bool running = true;
while (running){
double num1, num2;
Console.WriteLine("Enter the first number");
num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
num2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Choose the operation to be performed ");
    Console.WriteLine("'+' for Addition");
    Console.WriteLine("'-' for subtraction ");
    Console.WriteLine("'*' for multiplication");
    Console.WriteLine("'/' for division");
    Console.WriteLine("Enter your choice");
    ConsoleKeyInfo userinput = Console.ReadKey();
    char operation = userinput.KeyChar;
 
    double result = 0;
    double add(double num1, double num2)
    {
        return num1 + num2;

    }
    double subtract(double num1, double num2)
    {
        return num1 - num2;
    }
    double multiply(double num1, double num2)
    {
        return num1 * num2;
    }
    double divide(double num1, double num2)
    {
        return num1 / num2;
    }
    switch (operation)
    {
        case '+':
            result = add(num1, num2);
            break;
        case '-':
            result = subtract(num1, num2);
            break;
        case '*':
            result = multiply(num1, num2);
            break;
        case '/':
            if (num2 != 0)
            {
                result = divide(num1, num2);
            }
            else
            {
                Console.WriteLine("Error:Division by zero");
                running = false;
            }
            break;
        default:
            Console.WriteLine("invalid operation");
            break;
    }
            if (running)
            {
                Console.WriteLine("Result:" + result);
            }
            Console.WriteLine("Enter 'Y' to continue or Enter 'N' to Exit");
            ConsoleKeyInfo option = Console.ReadKey();

            if(option.KeyChar == 'Y' || option.KeyChar == 'y')
            {
                running = true;
        Console.Clear();
            }
    else if(option.KeyChar == 'N' || option.KeyChar == 'n')
        {
        running = false;
        Console.Clear();
        Console.WriteLine("Thank you!");

    }








}
