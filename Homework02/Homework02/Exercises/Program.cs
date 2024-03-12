
#region Exercises from presentation

//Exercise 5

int[] ArrayOfNumbers = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter a number");
    ArrayOfNumbers[i] = int.Parse(Console.ReadLine());

}
int sumOfNum = 0;
foreach (int number in ArrayOfNumbers)
{
    sumOfNum += number;
}

Console.WriteLine("The sum of the entered numbers is: " + sumOfNum);

Console.ReadLine();

//Exercise 6


string[] names = new string[10];
int currentIndex = 0;

while (true)
{
    Console.WriteLine("Enter name");
    string newName = Console.ReadLine();

    names[currentIndex] = newName;
    currentIndex++;

    Console.WriteLine("Do want to enter another name(Y / N)?");
    char choice;
    while (true)
    {

        choice = char.ToUpper(Console.ReadKey().KeyChar);

        if (choice == 'Y' || choice == 'N')
        {
            Console.WriteLine();
            break;
        }
        else 
        {
            Console.WriteLine("You've entered an invalid letter. Please enter Y or N.");
            
        }
    }
    if (choice == 'N')
    {
        break;
    }

}
for (int i = 0; i < currentIndex; i++)
{
    Console.WriteLine(names[i]);
}

Console.ReadLine() ;

#endregion

#region Homework Exercises
// TASK 1

int[] numbers = new int[6];
for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Enter a number: ");
    numbers[i] = int.Parse(Console.ReadLine());
}
int SumOfEven = 0;
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        SumOfEven += number;
    }
}

Console.WriteLine("Result: " + SumOfEven);

// TASK 2


string[] studentsG1 = new string[5] { "Sara", "Radica", "Anamarija", "Keti", "Simona" };
string[] studentsG2 = new string[5] { "Robert", "Luka", "Mihail", "Filip", "Jovan" };

int groupNum;
while (true)
{
    Console.WriteLine("Enter students group. 1 or 2");
    bool isParsed = int.TryParse(Console.ReadLine(), out groupNum);


    if (!isParsed)
    {
        Console.WriteLine("You've entered invalid number");
    }

    else if (groupNum != 1 && groupNum != 2)
    {
        Console.WriteLine("Please enter either 1 or 2");

    }
    else
    {
        Console.WriteLine("Students in Group " + groupNum + ":");
    }


    if (groupNum == 1)
    {
        foreach (string student in studentsG1)
        {
            Console.WriteLine(student);
        }
    }
    else if (groupNum == 2)
    {
        foreach (string student in studentsG2)
        {
            Console.WriteLine(student);
        }
        break;
    }
}
#endregion