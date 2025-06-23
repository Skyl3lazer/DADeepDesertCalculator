using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuneData.Model
{
    public class Fabricator : Building
    {
        public Fabricator(string name, Dictionary<Guid, int> materials, int powerDraw, string imagePath = "") : base(name, BuildingType.Fabricator, materials, powerDraw, imagePath)
        {
        }
    }
}
