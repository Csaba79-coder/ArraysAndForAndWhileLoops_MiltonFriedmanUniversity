using System;

namespace ArraysAndForAndWhileLoops_MiltonFriedmanUniversity
{
    class Program
    {
        static void Main(string[] args)
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                        Console.Write(i * j + "\t");
                    Console.WriteLine("");
                }


                /* int a = 1;
                int b = 1;
                while (a <= 10)
                {
                    while (b <= 10)
                    {
                        Console.Write(a * b + "\t");
                        b++;
                    }
                    Console.WriteLine();
                    a++;
                }


                int z = 1;
                while (z <= 10)
                {
                    for(int t = 1; t <= 10, t++)
                    {
                        Console.Write(z * t + "\t");
                    }
                    Console.WriteLine();
                    z++;
                } */


                int num;
                Console.Write("Please enter a number: ");
                num = int.Parse(Console.ReadLine());
                // Console.WriteLine("Your number was: " + num);
                switch (num)
                {
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    default:
                        Console.WriteLine("Your num was: " + num);
                        break;
                }


                int factorial = 1;
                for (int i = 1; i <= 10; i++)
                {
                    factorial *= i;
                    Console.WriteLine(factorial);
                }
                Console.ReadKey();

                int[] wholeNums = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
                int lengthOfArr = wholeNums.Length;
                int sum = 0;
                int product = 1;
            for (int i = 0; i < lengthOfArr; i++)
            {
                sum = sum + wholeNums[i];
                Console.Write("{0}. összeg: {1} \t", i, sum);
                product *= wholeNums[i];
                Console.WriteLine("{0}. szorzat {1}", i, product);
            }
        }
    }
}
