// See https://aka.ms/new-console-template for more information

using Calculator;
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
   
   
   
    
    switch (operation)
    {
        case '+':
             result = Addition.ToAdd(num1, num2);
            break;
        case '-':
            result = Subtraction.ToSubtract(num1, num2);
            break;
        case '*':
            result = Multiplication.ToMultiply(num1, num2);
            break;
        case '/':
          
                try
            {
                result = Division.ToDivide(num1, num2);
               
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
                  
            break;
           default:
            Console.WriteLine("invalid operation");
            running = false;
            break;
    }
            if (running)
            {
                Console.WriteLine("\n" + "Result:" + result);
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
