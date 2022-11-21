using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Nov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            //task2


            double salary = 2.54;
            Console.WriteLine(salary);
            string gender = "male";
            Console.WriteLine(gender);
            char first = 'A';
            Console.WriteLine('A');
            bool trueorfalse = false;
            Console.WriteLine(false);
            int phone = 0744433444;
            Console.WriteLine(phone);
            const int homeno = 23;
            Console.WriteLine(homeno);

            //task3
            string[] cars = { "kia", "ford", "bmw" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);

            //task4
            Console.WriteLine("Input your firstname: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Input your lastname: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Input your birthdate: ");
            string birth = Console.ReadLine();

            Console.WriteLine(fname + " " + lname + " " + birth);

            //task5
            int[] num = new int[10];
            num[0] = 1;
            Console.WriteLine(num[0]);
            num[1] = 1;
            Console.WriteLine(num[1]);
            num[2] = 2;
            Console.WriteLine(num[2]);
            num[3] = 3;
            Console.WriteLine(num[3]);
            num[4] = 4;
            Console.WriteLine(num[4]);
            num[5] = 5;
            Console.WriteLine(num[5]);
            num[6] = 6;
            Console.WriteLine(num[6]);
            num[7] = 7;
            Console.WriteLine(num[7]);
            num[8] = 8;
            Console.WriteLine(num[8]);
            num[9] = 9;
            Console.WriteLine(num[9]);

            //task6
            int Sum = num[0] + num[1] + num[2] + num[3] + num[4] +
                  num[5] + num[6] + num[7] + num[8] + num[9];
            Console.WriteLine("The sum =" + Sum);
        }
    }
}
