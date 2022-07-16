using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band? \n");
            string favoriteBand = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! My favorite color is {favoriteColor} too!!! Whats that? Your favorite animal is \n" +
                $"{favoriteAnimal}. Cool, my favorite band is {favoriteBand}");
            Console.ReadLine();//this is just to keep the console from closing right away

            Console.WriteLine("Lets do some simple 2 number math!!");
            Console.WriteLine("Whats your first number?");
            string digitOneString = Console.ReadLine();
            Console.WriteLine("Whats your second number?");
            string digitTwoString = Console.ReadLine();
            Console.WriteLine("now is it +, -, *, or / ?");
            string mathOperator = Console.ReadLine();

            int digitOne = int.Parse(digitOneString);
            int digitTwo = int.Parse(digitTwoString);

            if(mathOperator == "+")
            {
                int digitThree = DigitSum(digitOne, digitTwo);
                Console.WriteLine($"{digitOne} + {digitTwo} is {digitThree}");
                Console.ReadLine();//this is just to keep the console from closing right away
            }
            if (mathOperator == "-")
            {
                int digitThree = DigitSubtract(digitOne, digitTwo);
                Console.WriteLine($"{digitOne} - {digitTwo} is {digitThree}");
                Console.ReadLine();//this is just to keep the console from closing right away
            }
            if (mathOperator == "*")
            {
                int digitThree = DigitMultiply(digitOne, digitTwo);
                Console.WriteLine($"{digitOne} * {digitTwo} is {digitThree}");
                Console.ReadLine();//this is just to keep the console from closing right away
            }
            if (mathOperator == "/")
            {
                int digitThree = DigitDivide(digitOne, digitTwo);
                Console.WriteLine($"{digitOne} / {digitTwo} is {digitThree}");
                Console.ReadLine();//this is just to keep the console from closing right away
            }

        }
        public static int DigitSum(int digitOne, int digitTwo)
        {
            return digitOne + digitTwo;
        }

        public static int DigitSubtract(int digitOne,int digitTwo)
        {
            return digitOne - digitTwo;
        }
        public static int DigitMultiply(int digitOne, int digitTwo)
        {
            return digitOne * digitTwo;
        }
        public static int DigitDivide(int digitOne, int digitTwo)
        {
            return digitOne / digitTwo;
        }
    }
}
