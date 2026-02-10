namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //code for q1
        Console.WriteLine("Input an Integer:");
        int num = Convert.ToInt16(Console.ReadLine());

        bool isPrime = true;

        if (num <= 1) isPrime = false;

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
               isPrime = false;
               break;
            }
         }
        if (isPrime)
        {
            Console.WriteLine("Number is prime");
        }
        else
        {
            Console.WriteLine("Number is non-prime");
        }

        //code for q2
        Console.WriteLine("Input another Integer:");
        int num2 = Convert.ToInt16(Console.ReadLine());

        for (int i = 0; i < num2; i++)
        {
            for (int j = 0; j < num2; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }

        //code for q3
        Console.WriteLine("Input another Integer:");
        int num3 = Convert.ToInt16(Console.ReadLine());

        for(int row = 0; row < num3; row++)
        {
            for(int col = 0; col < num3; col++)
            {
                if(row >= col)
                {
                Console.Write("*");
                }
            }
            Console.WriteLine();
        }

        //code for bonus
        Console.WriteLine("Input another Integer:");
        int num4 = Convert.ToInt16(Console.ReadLine());

        for (int row = 1; row <= num4; row++)
        {
            for (int space = 1; space <= num4 - row; space++)
            {
                Console.Write(" ");
            }
            for (int col = 1; col <= row; col++)
            {
                Console.Write(row);
            }
            Console.WriteLine();
        }
    }
}
