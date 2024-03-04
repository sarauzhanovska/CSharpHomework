Console.WriteLine("Average Number");

Console.WriteLine("Enter first number:");
string firstNumber = Console.ReadLine();
float fnumber = Convert.ToInt32(firstNumber);

Console.WriteLine("Enter second number:");
string secondNumber = Console.ReadLine();
float snumber = Convert.ToInt32(secondNumber);

Console.WriteLine("Enter third number:");
string thirdNumber = Console.ReadLine();
float tnumber = Convert.ToInt32(thirdNumber);

Console.WriteLine("Enter fourth number:");
string fourthNumber = Console.ReadLine();
float frnumber = Convert.ToInt32(fourthNumber);

float result = (fnumber + snumber + tnumber + frnumber) / 4;
Console.WriteLine("The average of the above entered number is :" + result);


