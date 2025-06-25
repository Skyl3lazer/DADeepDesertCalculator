using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuneData.Model
{
    public class ChassisPart : Part
    {
        public ChassisPart(string name, VehicleType forVehicleType, Dictionary<Guid, int> materials, Dictionary<UtilityPartType, int> utilityPartCapacity, string imagePath = "") : base(name, PartType.Chassis, forVehicleType, materials, utilityPartCapacity, imagePath)
        {
        }
    }
}
