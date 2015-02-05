using System;
using System.Runtime.CompilerServices;


namespace _01.Square_Root
{
    public static class SquRtCalculator
    {
        public static void Main()
        {
            Console.WriteLine("Instert a number greater than 0 and hit Enter!");
            var input = Console.ReadLine();
            try
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new FormatException();
                }
                var argument = double.Parse(input);
                if (argument < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                var result = Math.Sqrt(argument);
                Console.WriteLine("Result: {0:0.##}", result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Value must be a number.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Value must be greater than 0.");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}