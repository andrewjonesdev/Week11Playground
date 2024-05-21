using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Week11Playground.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SkillTypeId
    {
        Conquerers,
        AdvancedConqurers,
        Armament,
        AdvancedArmament,
        Observation,
        AdvancedObservation,
        DevilFruitAwakening,
        LifeReturn,
        Shave,
        IronBody,
        FingerPistol,
        TempestKick,
        MoonWalk,
        PaperArts,
        Swordsman,
        Sniper,
        BeastTamer,
        MartialArtist,
        Assassin
    }
}
