using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuneData.Model
{
    public class PowerPart : Part
    {
        public PowerPart(string name, VehicleType forVehicleType, Dictionary<Guid, int> materials, Dictionary<UtilityPartType, int> utilityPartCapacity, string imagePath = "") : base(name, PartType.Power, forVehicleType, materials, utilityPartCapacity, imagePath)
        {
        }
    }
}
