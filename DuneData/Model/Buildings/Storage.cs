using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuneData.Model
{
    public class Storage : Building
    {
        public StorageType SType { get; set; }
        public int StorageAmount { get; set; }
        public Storage(string name, Dictionary<Guid, int> materials, StorageType sType, int storageAmount, string imagePath = "") : base(name, BuildingType.Storage, materials, 0, imagePath)
        {
            SType = sType;
            StorageAmount = storageAmount;
        }
    }
}
