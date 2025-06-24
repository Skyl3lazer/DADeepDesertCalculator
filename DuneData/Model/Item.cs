namespace DuneData.Model
{
    public class Item
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public decimal Volume { get; set; }
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public string Image { get; set; } = string.Empty;
        public Item(string name, decimal vol, ItemType type, string image = "")
        {
            Name = name;
            Volume = vol;
            Type = type;
            Image = image;
        }
    }
}
