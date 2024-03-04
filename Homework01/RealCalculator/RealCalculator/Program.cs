Console.WriteLine("Real Calculator");

Console.WriteLine("Enter first number:");
string firstNumber = Console.ReadLine();
float fnumber = Convert.ToInt32(firstNumber);

char operation;
Console.WriteLine("Input operation:");
operation = Convert.ToChar(Console.ReadLine());


Console.WriteLine("Enter second number:");
string secondNumber = Console.ReadLine();
float snumber = Convert.ToInt32(secondNumber);

float result = 0;

switch (operation)
{
    case '+':
        result = fnumber + snumber;
        break;
    case '-':
        result = fnumber - snumber;
        break;
    case '*':
        result = fnumber * snumber;
        break;
    case '/':
        result = fnumber / snumber;
        break;
    default:
        Console.WriteLine("Invalid operation");
        break;
}
        Console.WriteLine("Result: " + result);
