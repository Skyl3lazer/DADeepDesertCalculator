using DuneData.Model;
using System.Linq;

namespace DuneData.Data
{
    public class DuneDataService
    {
        static readonly IEnumerable<Item> ItemList = GetItemsStatic();
        static readonly Dictionary<string, Guid> MaterialDictionary = ItemList.ToDictionary(x => x.Name, x => x.Id);
        public Task<IEnumerable<Building>> GetBuildingsAsync()
        {
            string ImageBase = "DuneData.Images.Placeables.";

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
                    { MaterialDictionary["Calibrated Servok"], 20 }
                }, FuelType.None, -75, ImageBase+"Windtrap.webp"),

                new Utility("Horizontal Pentashield", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Steel Ingot"], 2 },
                    { MaterialDictionary["Cobalt Paste"], 20 },
                    { MaterialDictionary["Calibrated Servok"], 6 }
                }, FuelType.None, 0, ImageBase+"HorizontalPentashield.webp"),

                new Utility("Vertical Pentashield", new Dictionary<Guid, int>(){
                    { MaterialDictionary["Steel Ingot"], 2 },
                    { MaterialDictionary["Cobalt Paste"], 20 },
                    { MaterialDictionary["Calibrated Servok"], 6 }
                }, FuelType.None, 0, ImageBase+"VerticalPentashield.webp"),

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
            Task<IEnumerable<Item>> result = Task.FromResult(ItemList);
            return result;
        }
        public static IEnumerable<Item> GetItemsStatic()
        {
            string ImageBase = "DuneData.Images.Items.";
            IEnumerable<Item> items = new List<Item>()
            {
                //Fuels
                new Fuel("Fuel Cell", 0.2m, FuelType.FuelCell, 60, ImageBase+"FuelCell.webp"),
                new Fuel("Makeshift Filter", 5, FuelType.SmallFilter, 180, ImageBase+"MakeshiftFilter.webp"),
                new Fuel("Standard Filter", 5, FuelType.SmallFilter, 480, ImageBase+"StandardFilter.webp"),
                new Fuel("Particulate Filter", 5, FuelType.LargeFilter, 720, ImageBase+"ParticulateFilter.webp"),
                new Fuel("Advanced Particulate Filter", 5, FuelType.LargeFilter, 1440, ImageBase+"AdvancedParticulateFilter.webp"),
                new Fuel("Low-grade Lubricant", 0.2m, FuelType.LowLubricant, 60, ImageBase+"LowGradeLubricant.webp"),
                new Fuel("Industrial-grade Lubricant", 0.2m, FuelType.IndustrialLubricant, 90, ImageBase+"IndustrialGradeLubricant.webp"),
                new Fuel("Spice-infused Fuel Cell", 0.2m, FuelType.SpiceFuelCell, 90, ImageBase+"SpiceInfusedFuelCell.webp"),
                
                //Tier 0
                new Material("Salvaged Metal", 0.15m, ImageBase+"SalvagedMetal.webp"),
                new Material("Granite Stone", 0.1m, ImageBase+"GraniteStone.webp"),
                new Material("Plant Fiber", 0.1m, ImageBase+"PlantFiber.webp"),
                new Material("Water", 0, ImageBase+"Water.webp"),
                new Material("Solari", 0, ImageBase+"Solari.webp"),
                
                //Tier 1
                new Material("Copper Ingot", 0.25m, ImageBase+"CopperIngot.webp"),
                new Material("Advanced Servoks", 0.1m, ImageBase+"AdvancedServoks.webp"),
                new Material("EMF Generator", 0.1m, ImageBase+"EMFGenerator.webp"),
                new Material("Holtzman Actuator", 0.1m, ImageBase+"HoltzmanActuator.webp"),
                new Material("Mechanical Parts", 0.1m, ImageBase+"MechanicalParts.webp"),
                new Material("Micro-sandwich Fabric", 0.1m, ImageBase+"MicroSandwichFabric.webp"),
                new Material("Particle Capacitor", 0.1m, ImageBase+"ParticleCapacitor.webp"),
                new Material("Plasteel Microflora Fiber", 0.1m, ImageBase+"PlasteelMicrofloraFiber.webp"),
                
                //Tier 2
                new Material("Iron Ingot", 0.4m, ImageBase+"IronIngot.webp"),
                new Material("Silicone Block", 0.1m, ImageBase+"SiliconeBlock.webp"),
                new Material("Armor Plating", 0.1m, ImageBase+"ArmorPlating.webp"),
                new Material("Blade Parts", 0.1m, ImageBase+"BladeParts.webp"),
                new Material("Complex Machinery", 0.1m, ImageBase+"ComplexMachinery.webp"),
                new Material("Gun Parts", 0.1m, ImageBase+"GunParts.webp"),
                
                //Tier 3
                new Material("Steel Ingot", 0.5m, ImageBase+"SteelIngot.webp"),
                new Material("Cobalt Paste", 1, ImageBase+"CobaltPaste.webp"),
                new Material("Spice Melange", 0.2m, ImageBase+"SpiceMelange.webp"),
                new Material("Calibrated Servok", 0.1m, ImageBase+"CalibratedServok.webp"),
                new Material("Off-world Medical Supplies", 0.1m, ImageBase+"OffWorldMedicalSupplies.webp"),
                new Material("Range Finder", 0.1m, ImageBase+"RangeFinder.webp"),
                new Material("Ray Amplifier", 0.1m, ImageBase+"RayAmplifier.webp"),
                
                //Tier 4
                new Material("Aluminum Ingot", 0.7m, ImageBase+"AluminumIngot.webp"),
                new Material("Plastone", 0.2m, ImageBase+"Plastone.webp"),
                new Material("Carbide Scraps", 0.1m, ImageBase+"CarbideScraps.webp"),
                new Material("Diamondine Dust", 0.1m, ImageBase+"DiamondineDust.webp"),
                new Material("Heavy Caliber Compressor", 0.1m, ImageBase+"HeavyCaliberCompressor.webp"),
                new Material("Industrial Pump", 0.1m, ImageBase+"IndustrialPump.webp"),
                new Material("Insulated Fabric", 0.1m, ImageBase+"InsulatedFabric.webp"),
                new Material("Light Caliber Compressor", 0.1m, ImageBase+"LightCaliberCompressor.webp"),
                new Material("Sandtrout Leathers", 0.1m, ImageBase+"SandtroutLeathers.webp"),
                new Material("Stillsuit Tubing", 0.1m, ImageBase+"StillsuitTubing.webp"),
                
                //Tier 5
                new Material("Duraluminum Ingot", 0.9m, ImageBase+"DuraluminumIngot.webp"),
                new Material("Hydraulic Piston", 0.1m, ImageBase+"HydraulicPiston.webp"),
                new Material("Irradiated Slag", 0.1m, ImageBase+"IrradiatedSlag.webp"),
                new Material("Military Power Regulator", 0.1m, ImageBase+"MilitaryPowerRegulator.webp"),
                new Material("Thermoelectric Cooler", 0.1m, ImageBase+"ThermoelectricCooler.webp"),
                
                //Tier 6
                new Material("Plastanium Ingot", 1, ImageBase+"PlastaniumIngot.webp"),
                new Material("Advanced Machinery", 0.1m, ImageBase+"AdvancedMachinery.webp"),
                new Material("Atmospheric Filtered Fabric", 0.1m, ImageBase+"AtmosphericFilteredFabric.webp"),
                new Material("Ballistic Weave Fabric", 0.1m, ImageBase+"BallisticWeaveFabric.webp"),
                new Material("Carbide Blade Parts", 0.1m, ImageBase+"CarbideBladeParts.webp"),
                new Material("Diamodine Blade Parts", 0.1m, ImageBase+"DiamodineBladeParts.webp"),
                new Material("Fluid Efficient Industrial Pump", 0.1m, ImageBase+"FluidEfficientIndustrialPump.webp"),
                new Material("Fluted Heavy Caliber Compressor", 0.1m, ImageBase+"FlutedHeavyCaliberCompressor.webp"),
                new Material("Fluted Light Caliber Compressor", 0.1m, ImageBase+"FlutedLightCaliberCompressor.webp"),
                new Material("Improved Holtzman Actuator", 0.1m, ImageBase+"ImprovedHoltzmanActuator.webp"),
                new Material("Improved Watertube", 0.1m, ImageBase+"ImprovedWatertube.webp"),
                new Material("Irradiated Core", 0.1m, ImageBase+"IrradiatedCore.webp"),
                new Material("Overclocked Power Regulator", 0.1m, ImageBase+"OverclockedPowerRegulator.webp"),
                new Material("Plasteel Composite Armor Plating", 0.1m, ImageBase+"PlasteelCompositeArmorPlating.webp"),
                new Material("Plasteel Composite Blade Parts", 0.1m, ImageBase+"PlasteelCompositeBladeParts.webp"),
                new Material("Plasteel Composite Gun Parts", 0.1m, ImageBase+"PlasteelCompositeGunParts.webp"),
                new Material("Plasteel Plate", 0.1m, ImageBase+"PlasteelPlate.webp"),
                new Material("Precision Range Finder", 0.1m, ImageBase+"PrecisionRangeFinder.webp"),
                new Material("Thermo-Responsive Ray Amplifier", 0.1m, ImageBase+"ThermoResponsiveRayAmplifier.webp"),
                new Material("Tri-Forged Hydraulic Piston", 0.1m, ImageBase+"TriForgedHydraulicPiston.webp"),

            };
            return items;
        }
        public Task<IEnumerable<Vehicle>> GetVehiclesAsync()
        {
            string ImageBase = "DuneData.Images.Vehicles.";
            IEnumerable<Vehicle> vehicles = new List<Vehicle>()
            {
                new Vehicle("Sandbike", VehicleType.Motorcycle, new Dictionary<PartType, int>()
                {
                    { PartType.Chassis, 1},
                    { PartType.Power, 1},
                    { PartType.Front, 1},
                    { PartType.Engine, 1},
                    { PartType.Locomotion, 3}
                }, ImageBase+"Sandbike.webp")


            };
            Task<IEnumerable<Vehicle>> result = Task.FromResult(vehicles);
            return result;
        }
        public Task<IEnumerable<Part>> GetPartsAsync()
        {
            string ImageBase = "DuneData.Images.Parts.";
            IEnumerable<Part> parts = new List<Part>()
            {
                ////
                //Sandbike
                ////

                ///
                // Engines
                ///

                new EnginePart("Sandbike Engine Mk1", VehicleType.Motorcycle, new Dictionary<Guid, int>()
                {
                    { MaterialDictionary["Copper Ingot"], 5 },
                    { MaterialDictionary["Particle Capacitor"], 3 }
                }, new(), imagePath:ImageBase+"SandbikeEngine.webp"),

                ///
                // PSU
                ///

                new PowerPart("Sandbike PSU Mk1", VehicleType.Motorcycle, new Dictionary<Guid, int>()
                {
                    { MaterialDictionary["Copper Ingot"], 5 },
                    { MaterialDictionary["Particle Capacitor"], 3 }
                }, new(), imagePath:ImageBase+"SandbikePsu.webp"),

                ///
                // Utility
                ///

                new UtilityPart("Sandbike Booster Mk2", VehicleType.Motorcycle, new Dictionary<Guid, int>()
                {
                    { MaterialDictionary["Iron Ingot"], 23 },
                    { MaterialDictionary["Particle Capacitor"], 15 },
                    { MaterialDictionary["Holtzman Actuator"], 15 }
                }, UtilityPartType.Booster, imagePath:ImageBase+"SandbikeEngine.webp"),

                ///
                // Chassis
                ///

                new ChassisPart("Sandbike Chassis Mk1", VehicleType.Motorcycle, new Dictionary<Guid, int>()
                {
                    { MaterialDictionary["Copper Ingot"], 12 },
                    { MaterialDictionary["Advanced Servoks"], 5 }
                }, new(), imagePath:ImageBase+"SandbikeChassis.webp"),

                ///
                // Hull
                ///

                new FrontPart("Sandbike Hull Mk1", VehicleType.Motorcycle, new Dictionary<Guid, int>()
                {
                    { MaterialDictionary["Copper Ingot"], 12 },
                    { MaterialDictionary["Advanced Servoks"], 5 }
                }, new Dictionary<UtilityPartType, int>()
                {
                    { UtilityPartType.Scanner, 1},
                    { UtilityPartType.Other, 1 }
                }, imagePath:ImageBase+"SandbikeHull.webp"),

                ///
                // Treads
                ///

                new LocomotionPart("Sandbike Tread Mk1", VehicleType.Motorcycle, new Dictionary<Guid, int>()
                {
                    { MaterialDictionary["Copper Ingot"], 3 },
                    { MaterialDictionary["Advanced Servoks"], 1 }
                }, new(), imagePath:ImageBase+"SandbikeTread.webp"),

            };
            Task<IEnumerable<Part>> result = Task.FromResult(parts);
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
