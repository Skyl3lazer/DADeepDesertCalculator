using System.ComponentModel;

namespace DuneData.Model
{
    public enum BuildingType
    {
        None,
        Storage,
        Refinery,
        Fabricator,
        Utility,
        StakingUnit
    }
    public enum ItemType
    {
        Material,
        Fuel
    }
    public enum FuelType
    {
        None,
        IndustrialLubricant,
        SmallFilter,
        LargeFilter,
        LowLubricant,
        FuelCell,
        SpiceFuelCell
    }
    public enum StorageType
    {
        None,
        Water,
        Volume,
        Blood
    }
    public enum PartType
    {
        None,
        Engine,
        Front,
        Chassis,
        Power,
        Locomotion,
        Rear,
        Utility
    }
    public enum UtilityPartType
    {
        None,
        Other,
        Scanner,
        Booster,
        Inventory,
        Passenger,
        Turret
    }
    public enum VehicleType
    {
        None,
        Motorcycle,
        Buggy,
        Ornithopter,
        [Description("Assault Ornithopter")]
        AssaultOrnithopter,
        [Description("Carrier Ornithopter")]
        CarrierOrnithopter,
        Harvester
    }
}
