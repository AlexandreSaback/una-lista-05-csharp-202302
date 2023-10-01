using System;

public class Exercise_02
{
    public void run()
    {
        double[] numbers = new double[10];

        Console.WriteLine("Enter 10 real numbers:");
        for (int i = 0; i < 10; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Numbers in reverse order:");
        for (int i = 9; i >= 0; i--)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
