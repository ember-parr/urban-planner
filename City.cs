using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string CityName { get; set; }
        public string CityMayor { get; set; }
        public int YearEstablished { get; set; }
        public List<string> buildings { get; set; }
    }
}