using HomeworkExercise.Classes;


Driver bob = new Driver("Bob", 7);
Driver greg = new Driver("Greg", 8);
Driver jill = new Driver("Jill", 6);
Driver anne = new Driver("Anne", 6);

Car hyundai = new Car("Hyundai", 220);
Car mazda = new Car("Mazda", 210);
Car ferrari = new Car("Ferrari", 320);
Car porsche = new Car("Porsche", 300);

bool raceAgain = true;

while (raceAgain)
{

    Console.WriteLine("Choose the first Car!");
    Console.WriteLine("1.Hyundai \n2.Mazda \n3.Ferrari \n4.Porsche");
    int car1Choice;
    while (!int.TryParse(Console.ReadLine(), out car1Choice) || car1Choice < 1 || car1Choice > 4)
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
    }

    Console.WriteLine("Choose the first Driver!");
    Console.WriteLine("1.Bob \n2.Greg \n3.Jill \n4.Anne");
    int driver1Choice;
    while (!int.TryParse(Console.ReadLine(), out driver1Choice) || driver1Choice < 1 || driver1Choice > 4)
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
    }

    Console.WriteLine("Choose the second Car!");
    Console.WriteLine("1.Hyundai \n2.Mazda \n3.Ferrari \n4.Porsche");
    int car2Choice;
    while (!int.TryParse(Console.ReadLine(), out car2Choice) || car2Choice < 1 || car2Choice > 4)
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
    }

    Console.WriteLine("Choose the second Driver!");
    Console.WriteLine("1.Bob \n2.Greg \n3.Jill \n4.Anne");
    int driver2Choice;
    while (!int.TryParse(Console.ReadLine(), out driver2Choice) || driver2Choice < 1 || driver2Choice > 4)
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
    }

    switch (car1Choice)
    {
        case 1:
            hyundai.Driver = bob;
            break;
        case 2:
            mazda.Driver = greg;
            break;
        case 3:

            ferrari.Driver = jill;
            break;
        case 4:
            porsche.Driver = anne;
            break;
    }

    switch (car2Choice)
    {
        case 1:
            hyundai.Driver = bob;
            break;
        case 2:
            mazda.Driver = greg;
            break;
        case 3:
            ferrari.Driver = jill;
            break;
        case 4:
            porsche.Driver = anne;
            break;
    }

    RaceCar(GetSelectedCar(car1Choice, hyundai, mazda, ferrari, porsche), GetSelectedCar(car2Choice, hyundai, mazda, ferrari, porsche));

    Console.WriteLine("Do you want to race again? (Y/N)");
    string userInput = Console.ReadLine();

    if (userInput.ToUpper() != "Y")
    {
        raceAgain = false;
        Console.WriteLine("Thank you for playing!");
    }

}
static void RaceCar(Car car1, Car car2)
{
    if (car1.CalculateSpeed() > car2.CalculateSpeed())
    {
        Console.WriteLine($"Car {car1.Model} is faster");
    }
    else if (car2.CalculateSpeed() > car1.CalculateSpeed())
    {
        Console.WriteLine($"Car {car2.Model} is faster");
    }
    else
    {
        Console.WriteLine("Both of them finished at the same time");
    }
}

static Car GetSelectedCar(int choice, Car hyundai, Car mazda, Car ferrari, Car porsche)
{
    switch (choice)
    {
        case 1:
            return hyundai;
        case 2:
            return mazda;
        case 3:
            return ferrari;
        case 4:
            return porsche;
        default:
            return null;
    }
}