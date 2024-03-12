#region Homework Exercises

// Exercise 1


DateTime birthDate;

while (true)
{
    Console.WriteLine("Enter your birthday date (MM/dd/yyyy): ");
    string input = Console.ReadLine();

    if (!DateTime.TryParse(input, out birthDate))
    {
        Console.WriteLine("Invalid date format. Please enter the date in MM/dd/yyyy format.");
        continue;
    }

    if (birthDate > DateTime.Today)
    {
        Console.WriteLine("Invalid date. Please enter a date in the past.");
        continue;
    }

    break;
}

int age = CalculateAge(birthDate);
Console.WriteLine($"You are {age} years old.");


static int CalculateAge(DateTime birthDate)
{
    DateTime currentDate = DateTime.Today;
    int age = currentDate.Year - birthDate.Year;

    if (birthDate.Date > currentDate.AddYears(-age))
    {
        age--;
    }

    return age;
}


Console.ReadLine();

//Exercise 2


Console.WriteLine("Enter the date and time (MM/dd/yyyy hh:mm:ss): ");
DateTime dateTime = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Enter the wanted format (1 - MM/dd/yyyy, 2 - MM/dd/yyyy hh:mm:ss, 3 - dddd, dd MMMM yyyy HH:mm:ss, 4 - MM.dd.yyyy): ");
bool isParsed = int.TryParse(Console.ReadLine(), out int formatChoise);

string formattedDateTime = FormatDateTime(dateTime, formatChoise);
Console.WriteLine("Formatted Date and Time: " + formattedDateTime);


static string FormatDateTime(DateTime dateTime, int formatChoice)
{
    string formattedDateTime = "";
    switch (formatChoice)
    {
        case 1:
            formattedDateTime = dateTime.ToString("MM/dd/yyyy");
            break;
        case 2:
            formattedDateTime = dateTime.ToString("MM/dd/yyyy hh:mm:ss");
            break;
        case 3:
            formattedDateTime = dateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            break;
        case 4:
            formattedDateTime = dateTime.ToString("MM.dd.yyyy");
            break;
        default:
            formattedDateTime = "Format choice is not allowed";
            break;
    }
    return formattedDateTime;
}




#endregion
