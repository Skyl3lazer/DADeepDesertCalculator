namespace DuneData.Model
{
    public class Vehicle
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public VehicleType Type { get; set; }
        public string Name { get; set; } = "";

        private string _nickname = "";
        public string DisplayName => string.IsNullOrEmpty(_nickname) ? Name : _nickname;

        public Dictionary<PartType, int> RequiredParts { get; set; } = new();
        public Dictionary<Part, int> ChosenParts { get; set; } = new();
        public Dictionary<UtilityPartType, int> AllowedUtilityPartTypes => 
            ChosenParts.Select(a => a.Key.UtilityPartCapacity).SelectMany(d => d)
            .GroupBy(kvp => kvp.Key, (key, kvps) => new { Key = key, Value = kvps.Sum(kvp => kvp.Value) })
            .ToDictionary(x => x.Key, x => x.Value);
        public int UtilityPartCount { get; set; }
        public string Image { get; set; } = string.Empty;
        public Vehicle(string name, VehicleType type, Dictionary<PartType, int> requiredParts, string imagePath = "")
        {
            Name = name;
            Type = type;
            RequiredParts = requiredParts;
            Image = imagePath;
        }
    }
}
