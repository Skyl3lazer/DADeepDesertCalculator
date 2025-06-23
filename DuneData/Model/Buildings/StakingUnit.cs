using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuneData.Model
{
    public class StakingUnit : Building
    {
        public Dictionary<BuildingType, int> AdditionalCapacity { get; set; }
        public StakingUnit(string name, Dictionary<Guid, int> materials, Dictionary<BuildingType, int> additionalCapacity, string imagePath = "") : base(name, BuildingType.StakingUnit, materials, 0, imagePath)
        {
            AdditionalCapacity = additionalCapacity;
        }
    }
}
