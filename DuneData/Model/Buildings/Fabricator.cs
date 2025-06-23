using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuneData.Model.Buildings
{
    public class Fabricator : Building
    {
        public Fabricator(string name, IEnumerable<Material> materials, string imagePath = "") : base(name, BuildingType.Fabricator, materials, imagePath)
        {
        }
    }
}
