using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEight = new Building("512 8th Avenue");
            FiveOneTwoEight.Width = 51;
            FiveOneTwoEight.Depth = 28;
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




            // Console.WriteLine($"{FiveOneTwoEight.GetBuilding()}");
            // Console.WriteLine($"{OneTwoThree.GetBuilding()}");
            // Console.WriteLine($"{FourFiveSix.GetBuilding()}");


            List<Building> buildings = new List<Building>();
            buildings.Add(FiveOneTwoEight);
            buildings.Add(OneTwoThree);
            buildings.Add(FourFiveSix);

            City emberopolis = new City("Emberopolis", "Emberoni", 28, buildings);

            foreach (Building building in emberopolis.Buildings)
            {
                Console.WriteLine($@"{building.GetBuilding()}");
            }
        }
    }
}
