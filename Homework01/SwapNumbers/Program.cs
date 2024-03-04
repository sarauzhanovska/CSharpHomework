Console.WriteLine("Swap Numbers");

int number1;
int number2;
int temp;

Console.Write("Enter first number: ");
number1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
number2 = int.Parse(Console.ReadLine());

temp = number1;
number1 = number2;
number2 = temp;

Console.WriteLine("After Swapping");
Console.WriteLine("First number: " +  number1);
Console.WriteLine("Second number: " + number2);