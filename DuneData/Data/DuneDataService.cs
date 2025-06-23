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
        public Stream? GetImageStream(string path)
        {
            var asm = GetType().Assembly;
            var stream = asm.GetManifestResourceStream(path);
            return stream;
        }
    }
}
