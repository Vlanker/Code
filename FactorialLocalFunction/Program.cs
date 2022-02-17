var number = 10;
Console.WriteLine($"{number}! = {Factorial(number):N0}");

static int Factorial(int number)
{
    if (number < 0)
    {
        throw new ArgumentException($"{nameof(number)} cannot be less than zero.");
    }

    return LocalFactorial(number);

    int LocalFactorial(int localNumber)
    {
        if (localNumber < 1)
            return 1;

        return localNumber * LocalFactorial(localNumber - 1);
    }
}