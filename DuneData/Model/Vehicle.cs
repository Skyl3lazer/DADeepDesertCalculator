using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace DuneData.Model
{
    public class Vehicle
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public VehicleType Type { get; set; }
        public string Name { get; set; } = "";
        private string _nickname = "";
        public string DisplayName
        {
            get
            {
                return string.IsNullOrEmpty(_nickname) ? Name : _nickname;
            }
            set
            {
                _nickname = value;
            }
        }

        public Dictionary<PartType, int> RequiredParts { get; set; } = new();
        public IEnumerable<Part> ChosenParts { get; set; } = new List<Part>();
        public Dictionary<UtilityPartType, int> AllowedUtilityPartTypes => 
            ChosenParts.Select(a => a.UtilityPartCapacity).SelectMany(d => d)
            .GroupBy(kvp => kvp.Key, (key, kvps) => new { Key = key, Value = kvps.Sum(kvp => kvp.Value) })
            .ToDictionary(x => x.Key, x => x.Value);
        public int UtilityPartCount => AllowedUtilityPartTypes.Sum(a => a.Value);
        public string Image { get; set; } = string.Empty;
        public Vehicle(string name, VehicleType type, Dictionary<PartType, int> requiredParts, string imagePath = "")
        {
            Name = name;
            Type = type;
            RequiredParts = requiredParts;
            Image = imagePath;
        }

        [JsonConstructor]
        public Vehicle() { }
    }
}
