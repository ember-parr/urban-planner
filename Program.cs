using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEight = new Building("512 8th Avenue");
            FiveOneTwoEight.Width = 14;
            FiveOneTwoEight.Depth = 20;
            FiveOneTwoEight.Stories = 4;
            FiveOneTwoEight.Construct();
            FiveOneTwoEight.Purchase("Steve Brownlee");


            Building OneTwoThree = new Building("123 Main St.");
            OneTwoThree.Width = 1;
            OneTwoThree.Depth = 2;
            OneTwoThree.Stories = 3;
            OneTwoThree.Construct();
            OneTwoThree.Purchase("Adam Sheaf");


            Building FourFiveSix = new Building("453 1st Ave.");
            FourFiveSix.Width = 4;
            FourFiveSix.Depth = 5;
            FourFiveSix.Stories = 6;
            FourFiveSix.Construct();
            FourFiveSix.Purchase("Roey Wiz");




            Console.WriteLine($"{FiveOneTwoEight.GetBuilding()}");
            Console.Write($"{OneTwoThree.GetBuilding()}");
            Console.Write($"{FourFiveSix.GetBuilding()}");


        }
    }
}
