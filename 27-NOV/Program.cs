using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_NOV
{
    internal class identity
    {
        int age;
        string gender;
        string name;
        string Email;
        int id;
        int phone;

        public identity(int age1,string gender1,string name1,string Email1,int id1,int phone1)
        {
            age = age1;  
            gender = gender1;
            name = name1;
            Email = Email1;
            id = id1;
            phone = phone1;
        }
      
        public static void print(int age1, string gender1, string name1, string Email1, int id1, int phone1)
        {
            Console.WriteLine($" id: {id1}, gender {gender1}, the name is: {name1}, Email:{Email1},age:{age1}");
         }

        public static void agee(int age)
 
        {
            if (age == 18 ||age < 60)
            {
                Console.WriteLine($"you are {age} years old");
            }
            else {
                Console.WriteLine("your age out of the range");
                    }
        }
        
        public static void phonestarting(string phone) 
        {
            string phoneNO = phone.Substring(0, 3);
            if 
            (phoneNO == "077" || phoneNO == "078" || phoneNO == "079")
            {
                Console.WriteLine($"your number: {phone}");
            }else
            {
                Console.WriteLine("undefind");
            }
        }

            static void Main(string[] args)
        {
            identity myage = new identity(25,"male","wesam","abushaqrawesam@gmail.com",34,0780290566);
            identity.agee(25);
            identity.phonestarting("0780289");
        }
    }
}
