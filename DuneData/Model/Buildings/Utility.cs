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
        public StorageType SType { get; set; }
        public int Volume { get; set; }
        public Utility(string name, Dictionary<Guid, int> materials, FuelType fuelType, int powerDraw, string imagePath = "", StorageType sType = StorageType.None, int volume = 0) : base(name, BuildingType.Utility, materials, powerDraw, imagePath)
        {
            AcceptedFuelType = fuelType;
            SType = sType;
            Volume = volume;
        }
    }
}
