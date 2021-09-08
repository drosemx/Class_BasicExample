// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
//using System;

namespace Class_BasicExample
{
    class Program
    {

        public class Users
        {
            //Stablish  the attributes  for our class
            public string Name { get; set; }
            public int Age { get; set; }
         
                     
            public Users(string name, int age)
            {
                Name = name;
                Age = age;
            }
            //Creating a Method to get user details
            public void GetUserDetails()
            {
                Console.WriteLine("Name: {0}, Age: {1}", Name, Age);
            }
        }
        static void Main(string[] args)
        {
            Users user = new Users("Suresh Dasari", 30);
            user.GetUserDetails();
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
   
}