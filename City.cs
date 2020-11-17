using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string CityName { get; set; }
        public string CityMayor { get; set; }
        public int YearEstablished { get; set; }
        public List<Building> Buildings;

        public City(string cityName, string mayorName, int yearEst, List<Building> buildings)
        {
            CityName = cityName;
            CityMayor = mayorName;
            YearEstablished = yearEst;
            Buildings = buildings;
        }
    }
}