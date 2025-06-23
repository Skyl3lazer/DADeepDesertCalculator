namespace DuneData.Model
{
    public class Refinery : Building
    {
        public Refinery(string name, IEnumerable<Material> materials, string imagePath = "") : base(name, BuildingType.Refinery, materials, imagePath) { 
        }
    }
}
