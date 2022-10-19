using System;
using System.Collections.Generic;

namespace MethodsExercise3
{
    class Program
    {
        public static void PrintNumbers()
        {
            for(int i =-1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void MultiByThree()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }
        public static void EqualOrNah()
        {
            Console.WriteLine("Enter a number please.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number please.");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x} and {y} are" + ((x == y) ? "" : " not") + " equal.");
        }
        public static void EvenOrNah()
        {
            Console.WriteLine("Enter a number please");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x} is an" + ((x % 2 == 0) ? " even" : " odd") + " number.");
        }
        public static void PositiveOrNah()
        {
            Console.WriteLine("Enter a Number please.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x} is a" + ((x >= 0) ? " postive " : " negative ") + "number");
        }
        public static void VoterOrNah()
        {
            Console.WriteLine("How old are you, if you don't mind my asking?");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"You are" + ((x >= 18) ? " " : " not ") + "old enough to vote. PLEASE DO.");
        }
        public static void InRangeOrNah()
        {
            Console.WriteLine("Enter a Number please.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x} is " + ((x >= -10 && x <= 10) ? " within " : " outside ") + "the range of -10 to 10");
        }
        public static void MultiTable()
        {
            Console.WriteLine("Enter a Number please.");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i<=12; i++)
            {
                Console.WriteLine(x * i);
            }
        }
           

        static void Main(string[] args)
        {
            PrintNumbers();
            MultiByThree();
            EqualOrNah();
            EvenOrNah();
            PositiveOrNah();
            VoterOrNah();
            InRangeOrNah();
            MultiTable();


        }

    }
}
