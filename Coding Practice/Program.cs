PrintArray();

void PrintArray()
{
    int age = 0;
    bool validInput = false;

    while (validInput == false)
    {
        Console.WriteLine("Please enter your age:");
        string? input = Console.ReadLine();

        if (input != null)
        {
            validInput = int.TryParse(input, out age);
        }

        Console.WriteLine("\n...Invalid Input...\n");
        

    }
    int currentDate = DateTime.Now.Year;
    int dateOfBirth = currentDate - age;
    Console.WriteLine(dateOfBirth);
};