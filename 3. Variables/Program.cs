using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables 
            string name = "John";
            int age;


            //intialisation
            name = "John";
            age = 10;

                // what will be seen on console 
            Console.WriteLine("There once was a boy called " + name);
            Console.WriteLine(name + " was " + age + " of age.");
            Console.WriteLine(name + "really never liked his his name.");

            //change variable values
            age = 18;
            name = "Tom";

            Console.WriteLine("At age " + age + "he changed his name to " + name);

            //to freeze the console
            Console.ReadLine();

            /*Notes: you can also declare and initialise on the same line 
             * eg
             * string name = "John";
             */


        }
    }
}
