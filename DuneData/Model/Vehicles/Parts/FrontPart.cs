using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuneData.Model
{
    public class FrontPart : Part
    {
        public FrontPart(string name, VehicleType forVehicleType, Dictionary<Guid, int> materials, Dictionary<UtilityPartType, int> utilityPartCapacity, string imagePath = "") : base(name, PartType.Front, forVehicleType, materials, utilityPartCapacity, imagePath)
        {
        }
    }
}
