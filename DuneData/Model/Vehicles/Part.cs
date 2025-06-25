namespace DuneData.Model
{
    public abstract class Part
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public PartType Type { get; set; }
        public VehicleType ForVehicleType { get; set; }
        public string Name { get; set; } = "";
        public Dictionary<Guid, int> Materials { get; set; } = new();
        public Dictionary<UtilityPartType, int> UtilityPartCapacity { get; set; } = new();
        public string Image { get; set; } = string.Empty;
        public Part(string name, PartType type, VehicleType forVehicleType, Dictionary<Guid, int> materials, Dictionary<UtilityPartType, int> utilityPartCapacity, string imagePath = "")
        {
            Name = name;
            Type = type;
            ForVehicleType = forVehicleType;
            Materials = materials;
            Image = imagePath;
            UtilityPartCapacity = utilityPartCapacity;
        }
    }
}
