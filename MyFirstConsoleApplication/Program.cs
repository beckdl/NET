using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, location, date;


            name = "Daniel Beck";
            location = "Wyoming";
            date = DateTime.Now.ToString("MM/dd/yyyy");

            DateTime dtChristmas = new System.DateTime(2023, 12, 25);
            DateTime today = DateTime.Now;
            TimeSpan christmas = dtChristmas - today;

            Console.WriteLine($"My name is {name},");
            Console.WriteLine($"I am from {location}");

            Console.WriteLine(date);
            Console.WriteLine($"There are {christmas.Days} days until Christmas");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("What is the width of the window in meters?");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("What is the height of the window in meters?");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square meters");


            Console.ReadKey();
        }
    }
}
