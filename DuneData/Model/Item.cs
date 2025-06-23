namespace DuneData.Model
{
    public class Item
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public double Volume { get; set; }
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public string Image { get; set; } = string.Empty;
        public Item(string name, double vol, ItemType type, string image = "")
        {
            Name = name;
            Volume = vol;
            Type = type;
            Image = image;
        }
    }
}
