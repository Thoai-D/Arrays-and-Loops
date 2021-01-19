using System;

namespace Arrays_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
      PrintFirstAndLast(1, 2, 3);
        }

        static void Question1()
        {
            for(int i = 1; i <= 10; i = i + 1)
            {
                Console.WriteLine(i);
            }
        }

        static void Question2()
        {
            for(int i = 100; i >= 1; i = i - 1)
            {
                Console.WriteLine(i);
            }
        }


        static void PrintFirstAndLast(int[] numbers)
        {
            Console.WriteLine("First: " + numbers[0] + " Last: " + numbers[numbers.Length - 1]);
        }

        static void Question4()
        {
            int[] numbers = { 1, 2 , 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }


        static void Question5()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

        }
        

        static void Question6()
        {
            int[] numbers = new int[50];

            Random rnd = new Random(100);

            for (int i = 0; i < numbers.Length; i = i + 1)
            {
                int randomnumber = rnd.Next(100);
                numbers[i] = randomnumber;
            }

            int highest = numbers[0];
            int lowest = numbers[49];

            for (int i = 0; i < numbers.Length; i = i + 1)
            {
                if(numbers[i] > highest)
                {
                    highest = numbers[i];
                }
                else if(numbers[i] < lowest)
                {
                    lowest = numbers[i];
                }

                Console.WriteLine("Highest: " + highest + " Lowest: " + lowest);
            }




        }
            
    }
}
