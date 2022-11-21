using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Nov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK1
            Console.WriteLine("ENTER YOUR FIRST NUMBER");
            int fno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER YOUR LAST NUMBER");
            int Sno = Convert.ToInt32(Console.ReadLine());
            if (fno < Sno) { Console.WriteLine($"THE SMALL NUMBER IS:{fno}"); }
            else { Console.WriteLine($"THE SMALL NUMBER IS:{Sno}"); }
            ///    ////////////////////////////////////////////////////////////
            ///TASK2
            Console.WriteLine("your sign");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            { Console.WriteLine("-"); }
            else
            { Console.WriteLine("+"); }
            ////////////////////////////////////////////////////////////////////

            ///TASK3
            Console.WriteLine("ENTER YOUR FIRST NUMBER");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER YOUR MIDDLE NUMBER");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER YOUR LAST NUMBER");
            int no2 = Convert.ToInt32(Console.ReadLine());
            if (no < no1 && no < no2 && no1 < no2)
            {
                Console.WriteLine(no2 + " " + no1 + " " + no);
            }
            else if (no1 < no && no1 < no2 && no2 < no)
            {
                Console.WriteLine(no + " " + no2 + " " + no1);
            }
            else if (no2 < no && no2 < no1 && no < no1)
            {
                Console.WriteLine(no1 + " " + no + " " + no2);
            }
            else
            {
                Console.WriteLine(no + " " + no1 + " " + no2);
            }
            ////////////////////////////////////////////////////////////////////
            //task4
            int n0 = -5, n1 = -2, n2 = -6, n3 = 0, n4 = -1;
            if (n0 > n1 && n0 > n2 && n0 > n3 && n0 > n4)
            {
                Console.WriteLine(" the biggest number: " + n0);
            }
            else if (n1 > n0 && n1 > n2 && n1 > n3 && n1 > n4)
            {
                Console.WriteLine(" the biggest number: " + n1);
            }
            else if (n2 > n0 && n2 > n1 && n2 > n3 && n2 > n4)
            {
                Console.WriteLine(" the biggest number: " + n2);
            }
            else if (n3 > n0 && n3 > n1 && n3 > n2 && n3 > n4)
            {
                Console.WriteLine(" the biggest number: " + n3);
            }
            else
            {
                Console.WriteLine(" the biggest number: " + n4);
            }

                /////////////////////////////////////////////////////////////
                //task5
                Console.WriteLine("k/hour");
                int k = Convert.ToInt32(Console.ReadLine());
                double mile = k * 0.6213712;
                Console.WriteLine(mile);
                ////////////////////////////////////////////////////////////////////
                //task6
                Console.WriteLine("enter hour");
                int hour = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter min");
                int min = Convert.ToInt32(Console.ReadLine());
                int time = hour * 60;
                int time1 = time + min;
                Console.WriteLine(time1);
                ///////////////////////////////////////////////////////////////////
                ///task7
                Console.WriteLine("enter time in mins");
                int hourandmin = Convert.ToInt32(Console.ReadLine());

                int hours = hourandmin / 60;
                int time2 = hourandmin % 60;
                Console.WriteLine($"the time {hours} hour {time2} min");
                //////////////////////////////////////////////////////////////////
                ///task8 
                string[] array = { "hi ", "my name", "is not", "what", "you think it is" };
                Console.WriteLine(array[0].Substring(0, 3));
                Console.WriteLine(array[1].Substring(0, 3));
                Console.WriteLine(array[2].Substring(0, 3));
                Console.WriteLine(array[3].Substring(0, 3));
                Console.WriteLine(array[4].Substring(0, 3));
            }
        }
    }

