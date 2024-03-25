
// TASK 1

#region Homework Exercises


Queue<int> queue = new Queue<int>();

bool tryAgain = true;


while (tryAgain)
{
    Console.WriteLine("Enter a number: ");
    bool isParsed = int.TryParse(Console.ReadLine(), out int input);
    if (!isParsed)
    {
        Console.WriteLine("You've entered invalid number.");
    }
    else
    {
        queue.Enqueue(input);
        Console.WriteLine("Do you want to enter another number? Y or N");
        string secondInput = Console.ReadLine().ToUpper();
        if (secondInput.ToUpper() != "Y")
        {
            tryAgain = false;
        }

    }

}

Console.WriteLine("Numbers: ");
foreach (int num in queue)
{
    Console.WriteLine(num);
}




#endregion