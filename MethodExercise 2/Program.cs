using System;

namespace MethodExercise_2
{
    class Program
    {


        public static int add(int num1, int num2)
        {
            int total = num1 + num2;
            return total;
        }
        public static int subtract(int num1, int num2)
        {
            int total = num1 - num2;
            return total;
        }
        public static int multiply(int num1, int num2)
        {
            int total = num1 * num2;
            return total;
        }
        public static int divide(int num1, int num2)
        {
            int total = num1 / num2;
            return total;
        }
        public static int modulus(int num1, int num2)
        {
            int total = num1 % num2;
            return total;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Calculator time!");



            while (true)
            {
                Console.WriteLine(" 0 - Exit \n 1 - Addition \n 2 - Subtraction \n 3 - Multiplication \n 4 - Division \n 5 - Modulus");
                int use = Convert.ToInt32(Console.ReadLine());
                string input;
                int num1;
                int num2;
                switch (use)
                {
                    case 1:
                        Console.Write("Please enter the first number: ");
                        input = Console.ReadLine();
                        num1 = int.Parse(input);
                        Console.Write("Please enter the second number: ");
                        input = Console.ReadLine();
                        num2 = int.Parse(input);
                        Console.WriteLine(add(num1, num2));
                        Console.WriteLine(" ");
                        break;
                    case 2:
                        Console.Write("Please enter the first number: ");
                        input = Console.ReadLine();
                        num1 = int.Parse(input);
                        Console.Write("Please enter the second number: ");
                        input = Console.ReadLine();
                        num2 = int.Parse(input);
                        Console.WriteLine(subtract(num1, num2));
                        Console.WriteLine(" ");

                        break;
                    case 3:
                        Console.Write("Please enter the first number: ");
                        input = Console.ReadLine();
                        num1 = int.Parse(input);
                        Console.Write("Please enter the second number: ");
                        input = Console.ReadLine();
                        num2 = int.Parse(input);
                        Console.WriteLine(multiply(num1, num2));
                        Console.WriteLine(" ");

                        break;
                    case 4:
                        Console.Write("Please enter the first number: ");
                        input = Console.ReadLine();
                        num1 = int.Parse(input);
                        Console.Write("Please enter the second number: ");
                        input = Console.ReadLine();
                        num2 = int.Parse(input);
                        Console.WriteLine(divide(num1, num2));
                        Console.WriteLine(" ");

                        break;
                    case 5:
                        Console.Write("Please enter the first number: ");
                        input = Console.ReadLine();
                        num1 = int.Parse(input);
                        Console.Write("Please enter the second number: ");
                        input = Console.ReadLine();
                        num2 = int.Parse(input);
                        Console.WriteLine(modulus(num1, num2));
                        Console.WriteLine(" ");

                        break;
                    case 0:
                        return;

                }
            }
        }
    }
}
