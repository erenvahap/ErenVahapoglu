// See https://aka.ms/new-console-template for more information


/*
 
 I made an easy number guessing game with C# on .NET 7.0
 
 */

Random r = new Random(); 
int winnum = r.Next(0, 100); 

bool win = false;

try
{
    do
    {
        Console.WriteLine("Guess a number between 0 and 100");
        string s = Console.ReadLine();

        int i = int.Parse(s);

        if (i > winnum)
        {
            Console.WriteLine("Your guess is too high !!! Guess lower");
        }
        else if (i < winnum)
        {
            Console.WriteLine("Your guess is too low !!! Guess Higher");
        }
        else if (i == winnum)
        {
            Console.WriteLine("You find it CONGRACULATIONS");
            win = true;
        }

        Console.WriteLine();

    } while (win == false);

    Console.WriteLine("Thank you for playing !!!");
    Console.WriteLine("Press any key to finish the game...");
    Console.ReadKey(true);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Please enter a valid number. And try again !");
}

