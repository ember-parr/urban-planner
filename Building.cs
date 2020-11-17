using System;
using System.Collections.Generic;

namespace Planner
{
    public class Building
    {
        private string _designer = "Ember Parr";
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        public Building(string address)
        {
            Address = address;
        }

        public string Address { get; set; }

        public void Construct(Building building)
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string name)
        {
            _owner = name;
        }

    }




}