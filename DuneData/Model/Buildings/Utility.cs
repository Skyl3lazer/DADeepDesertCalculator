using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuneData.Model.Buildings
{
    public class Utility : Building
    {
        public Utility(string name, IEnumerable<Material> materials, string imagePath = "") : base(name, BuildingType.Utility, materials, imagePath)
        {
        }
    }
}
