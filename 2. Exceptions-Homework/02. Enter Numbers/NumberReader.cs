using System;

namespace _02.Enter_Numbers
{
    public class NumberReader
    {
        private static void Main()
        {
            int start;
            int end;
            SetStartAndEnd(out start, out end);
            int[] numbers = ReadNumber(start, end);
            string finalNumbers = string.Join(", ", numbers);
            Console.WriteLine("Final result - start: {0}, numbers: {1}, end: {2} ", start, finalNumbers, end);
        }

        private static void SetStartAndEnd(out int start, out int end)
        {
            try
            {
                Console.WriteLine("Enter number for start of range:");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentNullException();
                }
                bool result = int.TryParse(input, out start);
                if (!result)
                {
                    throw new ArgumentException();
                }
                Console.WriteLine("Enter number for end of range:");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentNullException();
                }
                result = int.TryParse(input, out end);
                if (!result)
                {
                    throw new ArgumentException();
                }
                if (start >= end || start + 10 > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentNullException)
            {

                Console.WriteLine("Value cannot be blank!");
                SetStartAndEnd(out start, out end);
            }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine("End number must be greater than start number!");
                SetStartAndEnd(out start, out end);
            }
            catch (ArgumentException)
            {

                Console.WriteLine("Value cannot be a string!");
                SetStartAndEnd(out start, out end);
            }
        }

        public static int[] ReadNumber(int start, int end)
        {
            int[] numbers = new int[10];
            try
            {
                int lowerNumber;
                Console.WriteLine("Enter number:");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentNullException();
                }
                bool result = int.TryParse(input, out lowerNumber);
                if (!result)
                {
                    throw new ArgumentException();
                }
                if (start < lowerNumber && end > lowerNumber)
                {
                    numbers[0] = lowerNumber;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
                for (int i = 1; i < numbers.Length; i++)
                {
                    int higherNumber;
                    Console.WriteLine("Enter number higher than the previous one:");
                    input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        throw new ArgumentNullException();
                    }
                    result = int.TryParse(input, out higherNumber);
                    if (!result)
                    {
                        throw new ArgumentException();
                    }
                    if (lowerNumber < higherNumber && end > lowerNumber)
                    {
                        numbers[i] = higherNumber;
                        lowerNumber = higherNumber;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }

                return numbers;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Value cannot be blank!");
                ReadNumber(start, end);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Next number must be greater than the previous number!");
                ReadNumber(start, end);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Value cannot be a string!");
                ReadNumber(start, end);
            }
            return numbers;
        }
    }
}