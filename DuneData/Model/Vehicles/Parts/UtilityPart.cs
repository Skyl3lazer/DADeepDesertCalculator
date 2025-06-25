using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuneData.Model
{
    public class UtilityPart : Part
    {
        public UtilityPartType UtilityType { get; set; }
        public UtilityPart(string name, VehicleType forVehicleType, Dictionary<Guid, int> materials, UtilityPartType utilityType, string imagePath = "") : base(name, PartType.Utility, forVehicleType, materials, new Dictionary<UtilityPartType, int>(), imagePath)
        {
            UtilityType = utilityType;
        }
    }
}
