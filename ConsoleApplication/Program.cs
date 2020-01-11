using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName, myLocation;

            Console.WriteLine("Please enter your name: ");
            myName = Console.ReadLine();
            Console.WriteLine("Please enter where you are from: ");
            myLocation = Console.ReadLine();

            Console.WriteLine("My name is " + myName + " and I am from " + myLocation + ".");

            DateTime Christmas = new DateTime(2020, 12, 25);


            Console.WriteLine("Today is " + DateTime.Now.ToString("MM/dd/yyyy"));
            Console.WriteLine("There are " + (Christmas - DateTime.Today) + " days until Christmas!");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please enter the frame width in meters: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Please enter the frame height in meters: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");

            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.ReadKey();
        }
    }
}
