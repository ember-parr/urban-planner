using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        private string _CityName { get; set; }
        private string _CityMayor { get; set; }
        private int _YearEstablished { get; set; }
        public List<Building> Buildings;

        public City(string cityName, string mayorName, int yearEst, List<Building> buildings)
        {
            _CityName = cityName;
            _CityMayor = mayorName;
            _YearEstablished = yearEst;
            Buildings = buildings;
        }
    }
}