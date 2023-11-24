using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the numbers of limit to find perfect and abundant numbers: ");
        int limit = int.Parse(Console.ReadLine());

        FindPerfectAndAbundantNumbers(limit);
    }

    static void FindPerfectAndAbundantNumbers(int limit)
    {
        int num = 1;

        do
        {
            int sumOfDivisors = SumOfDivisors(num);

            if (sumOfDivisors == num)
            {
                Console.WriteLine($"{num} is a perfect number.");
            }
            else if (sumOfDivisors > num)
            {
                Console.WriteLine($"{num} is an abundant number.");
            }

            num++;
        } while (num <= limit);
    }

    static int SumOfDivisors(int n)
    {
        int sum = 0;

        for (int i = 1; i < n; ++i)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }

        return sum;
    }
}