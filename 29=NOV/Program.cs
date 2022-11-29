using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_NOV
{
    internal class Employee
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string ID { get; set; }

        public Employee(string Name, int year, int month, int day, string ID)
        {
            this.Name = Name;
            Birthday = new DateTime(year, month, day);
            this.ID = ID;
        }

        public virtual void print()
        {
            Console.WriteLine($"Employee name:{Name}, Employee birthday:{Birthday}, Employee ID{ID}");
        }
    }

    class Manger : Employee
    {
        int salary;
     public Manger (string Name, int year, int month, int day, string ID,int salary): base(Name,year,month,day,ID)   
        {
            this.salary = salary;
        }
        public override void print()
        {
            Console.WriteLine($"Employee name:{Name}, Employee salary: {salary}");
        }
        public void Age()
        {
            DateTime now = DateTime.Now; TimeSpan value = now.Subtract(Birthday);

            Console.WriteLine("YOUR AGE:"+(int)value.TotalDays / 365);

        }

    }










        internal class Program
        {
            static void Main(string[] args)
            {
            Manger manger = new Manger("Wesam",1997,5,26,"a34",3000);
            manger.print();
            manger.Age();
        }
        }



   
}








   
