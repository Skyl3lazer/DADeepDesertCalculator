using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuneData.Model
{
    public class Fuel : Item
    {
        public FuelType FType { get; set; }
        public int DurationMinutes { get; set; }
        public Fuel(string name, double vol, FuelType ftype, int duration, string image = "") : base(name, vol, ItemType.Fuel, image)
        {
            FType = ftype;
            DurationMinutes = duration;
        }
    }
}
