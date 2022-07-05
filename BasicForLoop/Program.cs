
bool userContinue = false;

do
{
    Console.WriteLine("Enter a Number: ");

    int userNumber = int.Parse(Console.ReadLine());

    int sum = 0;


    for (int i = 0; i <= userNumber; i++)
    {
        sum += i; // increment sum variable
    }

    Console.WriteLine(sum);
    Console.WriteLine("Would you like to Continue? (y/n)");

    string answer = Console.ReadLine().ToLower();

    // ask user if they would like to continue

    if (answer == "y")
    {
        userContinue = true;
    }
    else
    {
        userContinue = false;
        Console.WriteLine("Goodbye!");
    }

} while (userContinue == true);

