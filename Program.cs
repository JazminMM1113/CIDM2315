namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        //Q1 Method Called
        Console.WriteLine("Enter first number:");
        int a = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int b = Convert.ToInt16(Console.ReadLine());

        int result = LargestNum(a,b);
        Console.WriteLine($"a = {a}; b = {b}");
        Console.WriteLine($"The largest number is: {result}");

        //Q2 Method Called
        Console.WriteLine("Enter a Number (N):");
        int N = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Left or Right?");
        string shape = Console.ReadLine();

        PrintTriangle(N, shape);

    }
    
    static int LargestNum(int num1, int num2)//Q1 Method
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
          return num2;
        }
    }

    static void PrintTriangle( int N, string shape)
    {
        Console.WriteLine($"N is: {N}; shape is {shape}");

        if(shape == "left")
        {
            for(int row = 0; row < N; row++)
            {
                for(int col = 0; col < N; col++)
                {
                if(row >= col)
                {
                Console.Write("*");
                }
                }
            Console.WriteLine();
            }
        }
        else if (shape == "right")
        {
            for (int row = 0; row < N; row++)
            {
            for (int col = 0; col < N - 1 - row; col++)
            {
                Console.Write(" ");
            }
            for (int col = 0; col <= row; col++)
            {
                Console.Write("*");    
            }
            Console.WriteLine();
            }
        }
    }
}
