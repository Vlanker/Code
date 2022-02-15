using static System.Console;

namespace WritingFunctional
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // RunTimesTable();
            // RunCardinalToOrdinal();
            RunFibImperative();
        }

        #region TimesTable

        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table:");
            for (int row = 1; row <= 12; row++)
            {
                WriteLine(
                    $"{row} x {number} = {row * number}");
            }

            WriteLine();
        }

        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Write("Enter a number between 0 and 255: ");
                isNumber = byte.TryParse(
                    ReadLine(), out byte number);
                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            } while (isNumber);
        }

        #endregion

        #region CardinalToOrdinal

        static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11: // case с 11 по 13
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    int lastDigit = number % 10;
                    string suffix = lastDigit switch
                    {
                        1 => "st",
                        2 => "nd",
                        3 => "rd",
                        _ => "th"
                    };
                    return $"{number}{suffix}";
            }
        }

        static void RunCardinalToOrdinal()
        {
            for (int number = 1; number <= 40; number++)
            {
                Write($"{CardinalToOrdinal(number)} ");
            }

            WriteLine();
        }

        #endregion

        #region Fibonacci

        static int FibImperative(int term)
        {
            // if (term == 1)
            // {
            //     return 0;
            // }
            // else if (term == 2)
            // {
            //     return 1;
            // }
            // else
            // {
            //     return FibImperative(term - 1) + FibImperative(term - 2);
            // }

            return term switch
            {
                1 => 0,
                2 => 1,
                _ => FibImperative(term - 1) + FibImperative(term - 2)
            };
        }

        static void RunFibImperative()
        {
            for (int i = 1; i <= 30; i++)
            {
                WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
                    arg0: CardinalToOrdinal(i),
                    arg1: FibImperative(term: i));
            }
        }

        #endregion
    }
}