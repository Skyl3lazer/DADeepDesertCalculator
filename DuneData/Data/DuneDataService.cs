using DuneData.Model;

namespace DuneData.Data
{
    public class DuneDataService
    {
        public Task<IEnumerable<Building>> GetBuildingsAsync()
        {
            string ImageBase = "DuneData.Images.Placeables.";
            IEnumerable<Building> buildings = new List<Building>()
            {
                new Refinery("Advanced Fremen Deathstill", new List<Material>(){ 
                }, ImageBase+"AdvancedFremenDeathstill.webp"),


            };

            Task<IEnumerable<Building>> result = Task.FromResult(buildings);

            return result;
        }
        public Task<IEnumerable<Item>> GetItemsAsync()
        {
            string ImageBase = "DuneData.Images.Items.";
            IEnumerable<Item> items = new List<Item>()
            {
                new Fuel("Fuel Cell", 0.2, FuelType.FuelCell, ImageBase+"FuelCell.webp"),
                new Fuel("Makeshift Filter", 5, FuelType.SmallFilter, ImageBase+"MakeshiftFilter.webp"),
                new Fuel("Standard Filter", 5, FuelType.SmallFilter, ImageBase+"StandardFilter.webp"),
                new Fuel("Particulate Filter", 5, FuelType.LargeFilter, ImageBase+"ParticulateFilter.webp"),
                new Fuel("Advanced Particulate Filter", 5, FuelType.LargeFilter, ImageBase+"AdvancedParticulateFilter.webp"),
                new Fuel("Low-grade Lubricant", 0.2, FuelType.LowLubricant, ImageBase+"LowGradeLubricant.webp"),
                new Fuel("Industrial-grade Lubricant", 0.2, FuelType.IndustrialLubricant, ImageBase+"IndustrialGradeLubricant.webp"),
                new Fuel("Spice-infused Fuel Cell", 0.2, FuelType.SpiceFuelCell, ImageBase+"SpiceInfusedFuelCell.webp"),

                new Material()
            };

            Task<IEnumerable<Item>> result = Task.FromResult(items);

            return result;
        }
        public Stream? GetImageStream(string path)
        {
            var asm = GetType().Assembly;
            var stream = asm.GetManifestResourceStream(path);
            return stream;
        }
    }
}
