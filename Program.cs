using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Username = "john";
            string Password = "pass123";


            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username == Username && password == Password)
            {
                Console.WriteLine("Login successful.");

            }
            else if (username == Username)
            {
                Console.WriteLine("Invalid username");
            }
            else
            {
                Console.WriteLine("Invalid password ");
            }


            Console.ReadKey();

            //nested if
            //int preMarks;
            //int finalMarks;
            //Console.WriteLine("enter pre marks");
            //preMarks=int.Parse(Console.ReadLine());
            //if(preMarks>=60)
            //{
            //    Console.WriteLine("enter final marks");
            //    finalMarks=int.Parse(Console.ReadLine());   
            //    if(finalMarks>=58)
            //    {
            //        Console.WriteLine("selected!!!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("clear the pre but fail in final");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("fail in pre");
            //}
            //Console.ReadKey();
        }
    }
}





