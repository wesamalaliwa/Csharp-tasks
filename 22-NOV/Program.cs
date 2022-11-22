using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_NOV
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ////////////////////////////////////////////
           ///task1
            int[] ARR = new int[] { 1, 7, 9, 45 };
            string[] arr2 = new string[] { "Str", "alex", "moh" };
            string[] arr3 = new string[] { "the", "fox", "over", "lazy", "dog" };
            //////////////////////////////////////////
            ///task2
            ///What the index of "Banana","Tomato"?
            //String[] fruits =["Tomato", "Banana", "Watermelon"]
            //// the index of tomato= 0  the index of banana=1
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            string[] arr4 = new string[] { };
            ///////////////////////////////////////////
            ///task3
            string[] food = new string[] { "mansaf", "maqlouba", "pizza", "shawrma", "burger" };
            string[] sport = new string[] { "football", "baskitball", "tennis" };
            string[] movie = new string[] { "Fight club", "old boy", "parasite", "7sins" };
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }
            for (int b = 0; b < sport.Length; b++)
            {
                Console.WriteLine(sport[b]);
            }
            foreach (string c in movie)
            {
                Console.WriteLine(movie);
            }
            ////////////////////////////////////////////
            ///task4
            
            
            Console.WriteLine("input three numbers with , between numbers:");  
            string number = Console.ReadLine();
            string[] num = number.Split(',');
            int[] mynum = new int[3];
            for (int i = 0; i < 3; i++)
            {
                mynum[i] = Convert.ToInt32(num[i]);


            }
            int sum = mynum[0] + mynum[1] + mynum[2];
            Console.WriteLine(sum);

            //////////////////////////////////////////
            ///task5
            int oddno = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0) 
                { 

                Console.Write(i + " ");
                oddno += i;
                }

            }
            //////////////////////////////////////////
            /////task6

            for (int r = 0; r < 4; r++)
            {

                for (int c = 4 - r; c > 0; c--)
                {
                    Console.Write(" ");
                }
                for (int  c = 0; c   <= r; c++)
                {
                    Console.Write("*" + " ");
                }
                Console.Write("\n");
            }
            ////////////////////////////////////////////////////////
            //task7
            int counter = 0;
            for (int r = 0; r < 4; r++)
            {
                for (int c = 4 - r; c > 0; c--)
                {
                    Console.Write(" ");
                }

                for (int c = 0; c <= r; c++)
                {

                    counter++;
                    Console.Write(counter + " ");
                }
                Console.Write("\n");
            }
            ////////////////////////////////////////////
///Write a program in C# to calculate the AVG of unlimited numbers that are not redundant
            ///optional


        }
    }
}

