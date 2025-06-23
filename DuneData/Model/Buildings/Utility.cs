using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuneData.Model
{
    public class Utility : Building
    {
        public FuelType AcceptedFuelType { get; set; }
        public Utility(string name, IEnumerable<Material> materials, FuelType fuelType, string imagePath = "") : base(name, BuildingType.Utility, materials, imagePath)
        {
            AcceptedFuelType = fuelType;
        }
    }
}
