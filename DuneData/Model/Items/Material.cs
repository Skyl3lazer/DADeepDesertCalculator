using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DuneData.Model
{
    public class Material : Item
    {
        public Material(string name, decimal vol, string image) : base(name, vol, ItemType.Material, image)
        {
            
        }
    }
}
