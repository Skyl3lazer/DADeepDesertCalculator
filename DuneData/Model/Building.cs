namespace DuneData.Model
{
    public abstract class Building
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public BuildingType Type { get; set; }
        public string Name { get; set; } = "";
        public Dictionary<Guid, int> Materials { get; set; } = new();
        public string Image { get; set; } = string.Empty;
        public int PowerDraw { get; set; } //Negative for draw, positive for generation
        public Building(string name, BuildingType type, Dictionary<Guid, int> materials, int powerDraw, string imagePath = "")
        {
            Name = name;
            Type = type;
            Materials = materials;
            Image = imagePath;
            PowerDraw = powerDraw;
        }
    }
}
