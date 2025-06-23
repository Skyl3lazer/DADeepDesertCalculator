namespace DuneData.Model
{
    public class Refinery : Building
    {
        public Refinery(string name, Dictionary<Guid, int> materials, int powerDraw, string imagePath = "") : base(name, BuildingType.Refinery, materials, powerDraw, imagePath) { 
        }
    }
}
