using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuneData.Model
{
    public class EnginePart : Part
    {
        public EnginePart(string name, VehicleType forVehicleType, Dictionary<Guid, int> materials, Dictionary<UtilityPartType, int> utilityPartCapacity, string imagePath = "") : base(name, PartType.Engine, forVehicleType, materials, utilityPartCapacity, imagePath)
        {
        }
    }
}
