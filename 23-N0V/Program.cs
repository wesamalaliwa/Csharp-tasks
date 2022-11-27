using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _23_Nov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1

            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int s = sum(num);
            double avg = s / (double)num.Length;
            Console.WriteLine("The summation for 10 number = " + s);
            Console.WriteLine("The average for 10 number = " + avg);
            Console.WriteLine();


            //Task2

            Console.WriteLine("Enter number of terms : ");
            int no1 = Convert.ToInt32(Console.ReadLine());
            cube(no1);

            //Task3

            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            int count = getYears(years);
            Console.WriteLine($"The numbers of the years array greater than 1950 = {count}");
            Console.WriteLine();

            //Task4

            Console.WriteLine("Enter your age in years");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"your age in year is {age} years your age in days are {ageInYear(age)} days");
            Console.WriteLine();

            //Task5

            Console.WriteLine("Enter number of chickens");
            int chickens = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of cows ");
            int cows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of pigs ");
            int pigs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" The number of legs for all animals ={animals(chickens, cows, pigs)}");
            Console.WriteLine("");

            //Task6

            Console.WriteLine("Enter your user name");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            Console.WriteLine($" Your username and password  {login(username, password)}");

            //Task7

            Console.WriteLine("Enter the number you want calc power for it");
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of power ");
            int powe = Convert.ToInt32(Console.ReadLine());
            power(numb, powe);

            //Task8 

            Console.WriteLine("Enter year in 1900-2024 to know if it leap year or not");
            int lYear = Convert.ToInt32(Console.ReadLine());

            leapYear(lYear);

            //Task9
            Console.WriteLine("Enter your number to check the prime numbers");
            int no = Convert.ToInt32(Console.ReadLine());
            primeNumber(no);

            //Task10
            Console.WriteLine();
            Console.WriteLine("Enter your Sentence");
            string sentence = Console.ReadLine();

            Console.WriteLine($"The number of words are {numOfWords(sentence)}");


        }
        //Task1
        public static int sum(int[] num)
        {
            int sum = 0;
            foreach (int item in num)
            {
                sum += item;
            }
            return sum;

        }
        //Task2

        public static void cube(int no)
        {

            for (int i = 1; i <= no; i++)
            {
                int cub = i * i * i;
                Console.WriteLine($"Number is: {i} and cube of the {i} is : {cub}");
            }
            Console.WriteLine();
        }
        //Task3 
        public static int getYears(int[] years)
        {
            int count = 0;

            foreach (var year in years)
            {
                if (year > 1950)
                {
                    count++;
                }
            }
            return count;
        }
        //Task4
        public static int ageInYear(int age)
        {
            int ageInDays = age * 360;
            return ageInDays;

        }

        //Task5 
        public static int animals(int chickens, int cows, int pigs)
        {
            int count = 0;
            int chickenLegs = chickens * 2;
            int cowsLegs = cows * 4;
            int pigsLegs = pigs * 4;

            count = chickenLegs + cowsLegs + pigsLegs;
            return count;
        }

        //Task6

        static bool login(string username, string password)
        {
            string[] usernames = { "WESAM", "ALI", "WASEEM" };
            string[] passwords = { "WES97", "ALI70", "WAS98" };

            for (int i = 0; i <= 2; i++)
            {
                if (username != usernames[i] && password != passwords[i])
                {
                    return false;
                }
            }
            return true;

        }
        //Task7

        public static void power(int numb, int powe)
        {
            int power = 1;
            for (int i = 0; i < powe; i++)
            {
                power *= numb;
            }

            Console.WriteLine($"The number is : {numb} the power of number are :{power}");
        }

        //Task8
        public static void leapYear(int year)
        {
            if (year < 2024 && year > 1900)
            {
                if (year == 1900)
                {
                    Console.WriteLine("isn't a leap year");
                }
                else if (year % 4 == 0)
                {
                    Console.WriteLine("is a leap year");
                }
                else
                {
                    Console.WriteLine("isn't a leap year");
                }
            }
            else
            {
                Console.WriteLine("The year not in the range");
            }
        }
        //Task9
        static void primeNumber(int number)
        {
            int prime = 0;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($" The {number} is Not Prime Number");
                    prime = 1;
                    break;
                }
            }
            if (prime == 0)
            {
                Console.WriteLine($" The {number} is Prime Number");
                return;
            }
        }

        //Task10 
        public static int numOfWords(string sentance)
        {
            int word = sentance.Split(' ').Length;
            return word;
        }

    }
}