using static System.Console;

RunFactorial();

static int Factorial(int number)
{
    // if (number < 1)
    // {
    //     return 0;
    // }
    //
    // if (number == 1)
    // {
    //     return 1;
    // }
    //
    // checked
    // {
    //     return number * Factorial(number - 1);
    // }

    return number switch
    {
        < 1 => 0,
        1 => 1,
        _ => checked(number * Factorial(number - 1))
    };
}


static void RunFactorial()
{
    for (int number = 1; number < 15; number++)
    {
        try
        {
            WriteLine($"{number}! =  {Factorial(number):N0}");
        }
        catch (OverflowException)
        {
            WriteLine($"{number}! is too big for a 32-bit integer.");
        }
    }
}