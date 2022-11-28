using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _28_NOV
{
    internal class Cars
    {

        public string make { set; get; }
        public int year { set; get; }
        public string type { set; get; }
        public int price { set; get; }
        public string model { set; get; }
        public int paletNo { set; get; }
        public string color { set; get; }

        public Cars(string make1, int year1, string type1, int price1, string model1, int paletNo1, string color1)
        {
            this.make = make1;
            this.year = year1;
            this.type = type1;
            this.price = price1;
            this.model = model1;
            this.paletNo = paletNo1;
            this.color = color1;

        }
        public void start()
        {
            Console.WriteLine("car is start");
        }
        public void stop()
        {
            Console.WriteLine("car is stop");
        }
        public void print()
        {
            Console.WriteLine($"the maker is:{make}, year of made:{year}, car type is{type}, car price:{price}, car model:{model},the palet number is:{paletNo}, car color is:{color}");
        }
    }
    class toyota : Cars
    {
        public string Shape { get; set; }
        public int Mirror { get; set; }
        public toyota(string make1, int year1, string type1, int price1, string model1, int paletNo1, string color1) : base(make1, year1, type1, price1, model1, paletNo1, color1)
        {

        }

        public toyota(string make1, int year1, string type1, int price1, string model1, int paletNo1, string color1, string shape, int mirror) : base(make1, year1, type1, price1, model1, paletNo1, color1)
        {
            this.Shape = shape;
            Mirror = mirror;
        }
        public void print1()
        {
            Console.WriteLine($"the shape is:{Shape}, number of mirror:{Mirror}");
        }
        public void distance(int l)
        {
            int dis = 20 * l;
            Console.WriteLine($"the distance = {dis}");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your car maker");
            string make = Console.ReadLine();

            Console.WriteLine("enter your car year");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your car type");
            string type = Console.ReadLine();

            Console.WriteLine("enter your car price");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your car model");
            string model = Console.ReadLine();

            Console.WriteLine("enter your car palet number");
            int paletNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your car color");
            string color = Console.ReadLine();


            Cars myCar = new Cars(make, year, type, price, model, paletNum, color);

            myCar.print();
            myCar.start();
            myCar.stop();

            Console.WriteLine("enter your car shape");
            string shape = Console.ReadLine();

            Console.WriteLine("enter your number of mirror");
            int mirror = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter  number of litter");
            int litter = Convert.ToInt32(Console.ReadLine());

            toyota car = new toyota(make, year, type, price, model, paletNum, color, shape, mirror);

            car.distance(litter);
            car.print();
            car.print1();

        }
    }
}