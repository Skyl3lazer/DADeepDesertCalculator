using DuneData.Model;
using System.Linq;

namespace DuneData.Data
{
    public class DuneDataService
    {
        public Task<IEnumerable<Building>> GetBuildingsAsync(IEnumerable<Item> materials)
        {
            string ImageBase = "DuneData.Images.Placeables.";
            Dictionary<string, Guid> MaterialDictionary = materials.ToDictionary(x => x.Name, x => x.Id);

            IEnumerable<Building> buildings = new List<Building>()
            {
                ////
                //Refineries
                ////

                new Refinery("Advanced Fremen Deathstill", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Plastanium Ingot"], 240 },
                    { MaterialDictionary["Silicone Block"], 170 },
                    { MaterialDictionary["Complex Machinery"], 70 }
                }, -350, ImageBase+"AdvancedFremenDeathstill.webp"),

                new Refinery("Blood Purifier", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Salvaged Metal"], 70 }
                }, -10, ImageBase+"BloodPurifier.webp"),

                new Refinery("Fremen Deathstill", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Steel Ingot"], 60 },
                    { MaterialDictionary["Silicone Block"], 28 },
                    { MaterialDictionary["Complex Machinery"], 32 }
                }, -200, ImageBase+"FremenDeathstill.webp"),

                new Refinery("Improved Blood Purifier", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Iron Ingot"], 50 },
                    { MaterialDictionary["Silicone Block"], 16 },
                    { MaterialDictionary["Complex Machinery"], 20 }
                }, -35, ImageBase+"ImprovedBloodPurifier.webp"),

                new Refinery("Large Ore Refinery", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Plastanium Ingot"], 380 },
                    { MaterialDictionary["Silicone Block"], 540 },
                    { MaterialDictionary["Spice Melange"], 400 },
                    { MaterialDictionary["Complex Machinery"], 200 },
                    { MaterialDictionary["Cobalt Paste"], 745 },
                    { MaterialDictionary["Advanced Machinery"], 40 }
                }, -350, ImageBase+"LargeOreRefinery.webp"),

                new Refinery("Large Spice Refinery", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Plastanium Ingot"], 950 },
                    { MaterialDictionary["Silicone Block"], 1080 },
                    { MaterialDictionary["Complex Machinery"], 350 },
                    { MaterialDictionary["Spice Melange"], 1000 },
                    { MaterialDictionary["Cobalt Paste"], 1110 },
                    { MaterialDictionary["Advanced Machinery"], 55 }
                }, -500, ImageBase+"LargeSpiceRefinery.webp"),

                new Refinery("Medium Chemical Refinery", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Duraluminum Ingot"], 150 },
                    { MaterialDictionary["Silicone Block"], 90 },
                    { MaterialDictionary["Complex Machinery"], 50 },
                    { MaterialDictionary["Spice Melange"], 35 },
                }, -350, ImageBase+"MediumChemicalRefinery.webp"),

                new Refinery("Medium Ore Refinery", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Steel Ingot"], 125 },
                    { MaterialDictionary["Cobalt Paste"], 60 },
                    { MaterialDictionary["Complex Machinery"], 50 }
                }, -45, ImageBase+"MediumOreRefinery.webp"),

                new Refinery("Medium Spice Refinery", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Plastanium Ingot"], 285 },
                    { MaterialDictionary["Silicone Block"], 225 },
                    { MaterialDictionary["Spice Melange"], 135 },
                    { MaterialDictionary["Complex Machinery"], 100 },
                    { MaterialDictionary["Cobalt Paste"], 190 }
                }, -350, ImageBase+"MediumSpiceRefinery.webp"),

                new Refinery("Small Chemical Refinery", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Copper Ingot"], 45 }
                }, -15, ImageBase+"SmallChemicalRefinery.webp"),

                new Refinery("Small Ore Refinery", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Salvaged Metal"], 90 },
                }, -15, ImageBase+"SmallOreRefinery.webp"),

                new Refinery("Spice Refinery", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Duraluminum Ingot"], 160 },
                    { MaterialDictionary["Silicone Block"], 130 },
                    { MaterialDictionary["Cobalt Paste"], 80 },
                    { MaterialDictionary["Complex Machinery"], 70 }
                }, -200, ImageBase+"SpiceRefinery.webp"),

                ////
                //Utilities
                ////

                new Utility("Advanced Sub-Fief Console", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Salvaged Metal"], 40 }
                }, FuelType.None, -15, ImageBase+"AdvancedSubFiefConsole.webp"),

                new Utility("Fuel-Powered Generator", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Salvaged Metal"], 45 }
                }, FuelType.FuelCell, 75, ImageBase+"FuelPoweredGenerator.webp"),

                new Utility("Large Windtrap", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Duraluminum Ingot"], 240 },
                    { MaterialDictionary["Silicone Block"], 250 },
                    { MaterialDictionary["Calibrated Servok"], 70 },
                    { MaterialDictionary["Spice Melange"], 3 }
                }, FuelType.LargeFilter, -135, ImageBase+"LargeWindtrap.webp", StorageType.Water, 500),

                new Utility("Recycler", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Copper Ingot"], 160 }
                }, FuelType.None, -15, ImageBase+"Recycler.webp"),

                new Utility("Repair Station", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Iron Ingot"], 160 }
                }, FuelType.None, -20, ImageBase+"RepairStation.webp"),

                new Utility("Spice-Powered Generator", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Plastanium Ingot"], 430 },
                    { MaterialDictionary["Silicone Block"], 180 },
                    { MaterialDictionary["Spice Melange"], 270 },
                    { MaterialDictionary["Complex Machinery"], 100 },
                    { MaterialDictionary["Cobalt Paste"], 300 },
                    { MaterialDictionary["Advanced Machinery"], 40 }
                }, FuelType.SpiceFuelCell, 1000, ImageBase+"SpicePoweredGenerator.webp"),

                new Utility("Sub-Fief Console", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Salvaged Metal"], 25 }
                }, FuelType.None,-15, ImageBase+"SubFiefConsole.webp"),

                new Utility("Directional Wind Turbine", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Duraluminum Ingot"], 120 },
                    { MaterialDictionary["Cobalt Paste"], 160 },
                    { MaterialDictionary["Calibrated Servok"], 50 },
                    { MaterialDictionary["Spice Melange"], 3 }
                }, FuelType.IndustrialLubricant, 350, ImageBase+"DirectionalWindTurbine.webp"),

                new Utility("Wind Turbine", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Steel Ingot"], 45 },
                    { MaterialDictionary["Cobalt Paste"], 65 },
                    { MaterialDictionary["Calibrated Servok"], 20 }
                }, FuelType.LowLubricant, 150, ImageBase+"WindTurbine.webp"),

                new Utility("Windtrap", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Steel Ingot"], 90 },
                    { MaterialDictionary["Silicone Block"], 30 },
                    { MaterialDictionary["Calibrated Servok"], 20 },
                }, FuelType.None, -75, ImageBase+"Windtrap.webp"),

                ////
                //Fabricators
                ////

                new Fabricator("Advanced Garment Fabricator", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Plastanium Ingot"], 140 },
                    { MaterialDictionary["Silicone Block"], 180 },
                    { MaterialDictionary["Complex Machinery"], 100 },
                    { MaterialDictionary["Spice Melange"], 45 },
                    { MaterialDictionary["Cobalt Paste"], 150 },
                    { MaterialDictionary["Armor Plating"], 115 }
                }, -150, ImageBase+"AdvancedGarmentFabricator.webp"),

                new Fabricator("Advanced Survival Fabricator", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Plastanium Ingot"], 140 },
                    { MaterialDictionary["Silicone Block"], 180 },
                    { MaterialDictionary["Complex Machinery"], 100 },
                    { MaterialDictionary["Spice Melange"], 45 },
                    { MaterialDictionary["Cobalt Paste"], 150 },
                    { MaterialDictionary["Thermoelectric Cooler"], 30 }
                }, -150, ImageBase+"AdvancedSurvivalFabricator.webp"),

                new Fabricator("Advanced Vehicle Fabricator", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Plastanium Ingot"], 140 },
                    { MaterialDictionary["Silicone Block"], 180 },
                    { MaterialDictionary["Complex Machinery"], 100 },
                    { MaterialDictionary["Spice Melange"], 45 },
                    { MaterialDictionary["Cobalt Paste"], 150 },
                    { MaterialDictionary["Industrial Pump"], 50 }
                }, -150, ImageBase+"AdvancedVehicleFabricator.webp"),

                new Fabricator("Advanced Weapons Fabricator", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Plastanium Ingot"], 140 },
                    { MaterialDictionary["Silicone Block"], 180 },
                    { MaterialDictionary["Complex Machinery"], 100 },
                    { MaterialDictionary["Spice Melange"], 45 },
                    { MaterialDictionary["Cobalt Paste"], 150 },
                    { MaterialDictionary["Military Power Regulator"], 40 }
                }, -150, ImageBase+"AdvancedWeaponsFabricator.webp"),

                new Fabricator("Fabricator", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Salvaged Metal"], 75 }
                }, -10, ImageBase+"Fabricator.webp"),

                new Fabricator("Garment Fabricator", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Steel Ingot"], 40 },
                    { MaterialDictionary["Complex Machinery"], 30 }
                }, -40, ImageBase+"GarmentFabricator.webp"),

                new Fabricator("Survival Fabricator", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Steel Ingot"], 40 },
                    { MaterialDictionary["Complex Machinery"], 30 }
                }, -40, ImageBase+"SurvivalFabricator.webp"),

                new Fabricator("Vehicles Fabricator", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Steel Ingot"], 40 },
                    { MaterialDictionary["Complex Machinery"], 30 }
                }, -40, ImageBase+"VehiclesFabricator.webp"),

                new Fabricator("Weapons Fabricator", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Steel Ingot"], 40 },
                    { MaterialDictionary["Complex Machinery"], 30 }
                }, -40, ImageBase+"WeaponsFabricator.webp"),
                
                ////
                //Storage
                ////

                new Storage("Chest", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Iron Ingot"], 20 }
                }, StorageType.Volume, 750, ImageBase+"Chest.webp"),

                new Storage("Large Water Cistern", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Duraluminum Ingot"], 150 },
                    { MaterialDictionary["Silicone Block"], 160 },
                    { MaterialDictionary["Industrial Pump"], 25 }
                }, StorageType.Water, 100000, ImageBase+"LargeWaterCistern.webp"),

                new Storage("Medium Storage Container", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Plastanium Ingot"], 70 },
                    { MaterialDictionary["Silicone Block"], 14 },
                    { MaterialDictionary["Spice Melange"], 4 }
                }, StorageType.Volume, 3500, ImageBase+"MediumStorageContainer.webp"),

                new Storage("Medium Water Cistern", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Steel Ingot"], 60 },
                    { MaterialDictionary["Silicone Block"], 30 }
                }, StorageType.Water, 25000, ImageBase+"MediumWaterCistern.webp"),

                new Storage("Small Storage Container", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Salvaged Metal"], 35 }
                }, StorageType.Volume, 250, ImageBase+"SmallStorageContainer.webp"),

                new Storage("Storage Container", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Aluminum Ingot"], 45 },
                    { MaterialDictionary["Silicone Block"], 8 }
                }, StorageType.Volume, 1750, ImageBase+"StorageContainer.webp"),

                ////
                //Staking Units
                ////

                new StakingUnit("Staking Unit", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Steel Ingot"], 15 },
                    { MaterialDictionary["Solari"], 15000 }
                }, new Dictionary<BuildingType, int>(){
                    { BuildingType.Refinery, 10 }
                }, ImageBase+"StakingUnit.webp"),

                new StakingUnit("Vertical Staking Unit", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Steel Ingot"], 15 },
                    { MaterialDictionary["Solari"], 15000 }
                }, new Dictionary<BuildingType, int>(){
                    { BuildingType.Refinery, 10 }
                }, ImageBase+"StakingUnit.webp")
            };

            Task<IEnumerable<Building>> result = Task.FromResult(buildings);

            return result;
        }
        public Task<IEnumerable<Item>> GetItemsAsync()
        {
            string ImageBase = "DuneData.Images.Items.";
            IEnumerable<Item> items = new List<Item>()
            {
                //Fuels
                new Fuel("Fuel Cell", 0.2, FuelType.FuelCell, ImageBase+"FuelCell.webp"),
                new Fuel("Makeshift Filter", 5, FuelType.SmallFilter, ImageBase+"MakeshiftFilter.webp"),
                new Fuel("Standard Filter", 5, FuelType.SmallFilter, ImageBase+"StandardFilter.webp"),
                new Fuel("Particulate Filter", 5, FuelType.LargeFilter, ImageBase+"ParticulateFilter.webp"),
                new Fuel("Advanced Particulate Filter", 5, FuelType.LargeFilter, ImageBase+"AdvancedParticulateFilter.webp"),
                new Fuel("Low-grade Lubricant", 0.2, FuelType.LowLubricant, ImageBase+"LowGradeLubricant.webp"),
                new Fuel("Industrial-grade Lubricant", 0.2, FuelType.IndustrialLubricant, ImageBase+"IndustrialGradeLubricant.webp"),
                new Fuel("Spice-infused Fuel Cell", 0.2, FuelType.SpiceFuelCell, ImageBase+"SpiceInfusedFuelCell.webp"),
                
                //Tier 0
                new Material("Salvaged Metal", 0.15, ImageBase+"SalvagedMetal.webp"),
                new Material("Granite Stone", 0.1, ImageBase+"GraniteStone.webp"),
                new Material("Plant Fiber", 0.1, ImageBase+"PlantFiber.webp"),
                new Material("Water", 0, ImageBase+"Water.webp"),
                new Material("Solari", 0, ImageBase+"Solari.webp"),
                
                //Tier 1
                new Material("Copper Ingot", 0.25, ImageBase+"CopperIngot.webp"),
                new Material("Advanced Servoks", 0.1, ImageBase+"AdvancedServoks.webp"),
                new Material("EMF Generator", 0.1, ImageBase+"EMFGenerator.webp"),
                new Material("Holtzman Actuator", 0.1, ImageBase+"HoltzmanActuator.webp"),
                new Material("Mechanical Parts", 0.1, ImageBase+"MechanicalParts.webp"),
                new Material("Micro-sandwich Fabric", 0.1, ImageBase+"MicroSandwichFabric.webp"),
                new Material("Particle Capacitor", 0.1, ImageBase+"ParticleCapacitor.webp"),
                new Material("Plasteel Microflora Fiber", 0.1, ImageBase+"PlasteelMicrofloraFiber.webp"),
                
                //Tier 2
                new Material("Iron Ingot", 0.4, ImageBase+"IronIngot.webp"),
                new Material("Silicone Block", 0.1, ImageBase+"SiliconeBlock.webp"),
                new Material("Armor Plating", 0.1, ImageBase+"ArmorPlating.webp"),
                new Material("Blade Parts", 0.1, ImageBase+"BladeParts.webp"),
                new Material("Complex Machinery", 0.1, ImageBase+"ComplexMachinery.webp"),
                new Material("Gun Parts", 0.1, ImageBase+"GunParts.webp"),
                
                //Tier 3
                new Material("Steel Ingot", 0.5, ImageBase+"SteelIngot.webp"),
                new Material("Cobalt Paste", 1, ImageBase+"CobaltPaste.webp"),
                new Material("Spice Melange", 0.2, ImageBase+"SpiceMelange.webp"),
                new Material("Calibrated Servok", 0.1, ImageBase+"CalibratedServok.webp"),
                new Material("Off-world Medical Supplies", 0.1, ImageBase+"OffWorldMedicalSupplies.webp"),
                new Material("Range Finder", 0.1, ImageBase+"RangeFinder.webp"),
                new Material("Ray Amplifier", 0.1, ImageBase+"RayAmplifier.webp"),
                
                //Tier 4
                new Material("Aluminum Ingot", 0.7, ImageBase+"AluminumIngot.webp"),
                new Material("Plastone", 0.2, ImageBase+"Plastone.webp"),
                new Material("Carbide Scraps", 0.1, ImageBase+"CarbideScraps.webp"),
                new Material("Diamondine Dust", 0.1, ImageBase+"DiamondineDust.webp"),
                new Material("Heavy Caliber Compressor", 0.1, ImageBase+"HeavyCaliberCompressor.webp"),
                new Material("Industrial Pump", 0.1, ImageBase+"IndustrialPump.webp"),
                new Material("Insulated Fabric", 0.1, ImageBase+"InsulatedFabric.webp"),
                new Material("Light Caliber Compressor", 0.1, ImageBase+"LightCaliberCompressor.webp"),
                new Material("Sandtrout Leathers", 0.1, ImageBase+"SandtroutLeathers.webp"),
                new Material("Stillsuit Tubing", 0.1, ImageBase+"StillsuitTubing.webp"),
                
                //Tier 5
                new Material("Duraluminum Ingot", 0.9, ImageBase+"DuraluminumIngot.webp"),
                new Material("Hydraulic Piston", 0.1, ImageBase+"HydraulicPiston.webp"),
                new Material("Irradiated Slag", 0.1, ImageBase+"IrradiatedSlag.webp"),
                new Material("Military Power Regulator", 0.1, ImageBase+"MilitaryPowerRegulator.webp"),
                new Material("Thermoelectric Cooler", 0.1, ImageBase+"ThermoelectricCooler.webp"),
                
                //Tier 6
                new Material("Plastanium Ingot", 1, ImageBase+"PlastaniumIngot.webp"),
                new Material("Advanced Machinery", 0.1, ImageBase+"AdvancedMachinery.webp"),
                new Material("Atmospheric Filtered Fabric", 0.1, ImageBase+"AtmosphericFilteredFabric.webp"),
                new Material("Ballistic Weave Fabric", 0.1, ImageBase+"BallisticWeaveFabric.webp"),
                new Material("Carbide Blade Parts", 0.1, ImageBase+"CarbideBladeParts.webp"),
                new Material("Diamodine Blade Parts", 0.1, ImageBase+"DiamodineBladeParts.webp"),
                new Material("Fluid Efficient Industrial Pump", 0.1, ImageBase+"FluidEfficientIndustrialPump.webp"),
                new Material("Fluted Heavy Caliber Compressor", 0.1, ImageBase+"FlutedHeavyCaliberCompressor.webp"),
                new Material("Fluted Light Caliber Compressor", 0.1, ImageBase+"FlutedLightCaliberCompressor.webp"),
                new Material("Improved Holtzman Actuator", 0.1, ImageBase+"ImprovedHoltzmanActuator.webp"),
                new Material("Improved Watertube", 0.1, ImageBase+"ImprovedWatertube.webp"),
                new Material("Irradiated Core", 0.1, ImageBase+"IrradiatedCore.webp"),
                new Material("Overclocked Power Regulator", 0.1, ImageBase+"OverclockedPowerRegulator.webp"),
                new Material("Plasteel Composite Armor Plating", 0.1, ImageBase+"PlasteelCompositeArmorPlating.webp"),
                new Material("Plasteel Composite Blade Parts", 0.1, ImageBase+"PlasteelCompositeBladeParts.webp"),
                new Material("Plasteel Composite Gun Parts", 0.1, ImageBase+"PlasteelCompositeGunParts.webp"),
                new Material("Plasteel Plate", 0.1, ImageBase+"PlasteelPlate.webp"),
                new Material("Precision Range Finder", 0.1, ImageBase+"PrecisionRangeFinder.webp"),
                new Material("Thermo-Responsive Ray Amplifier", 0.1, ImageBase+"ThermoResponsiveRayAmplifier.webp"),
                new Material("Tri-Forged Hydraulic Piston", 0.1, ImageBase+"TriForgedHydraulicPiston.webp"),

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
