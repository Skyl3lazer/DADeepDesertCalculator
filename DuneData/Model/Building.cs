namespace DuneData.Model
{
    public class Building
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public BuildingType Type { get; set; }
        public string Name { get; set; } = "";
        public IEnumerable<Material> Materials { get; set; } = new List<Material>();
        public string Image { get; set; } = string.Empty;
        public Building(string name, BuildingType type, IEnumerable<Material> materials, string imagePath = "")
        {
            Name = name;
            Type = type;
            Materials = materials;
            Image = imagePath;
        }
    }
}
