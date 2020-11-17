using System;

namespace Planner
{
    public class Building
    {
        private string _designer = "Ember Parr";
        private DateTime _dateConstructed = DateTime.Now;
        private string _address = "123 Main St.";
        private string _owner = "Adam S.";

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
    }




}