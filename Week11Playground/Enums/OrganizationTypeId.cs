using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Week11Playground.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrganizationTypeId
    {
        Pirate,
        Marine,
        Revolutionary,
        BountyHunter,
        CipherPol,
        GodsKnight,
        Warlord,
        ElderPlanet,
        CountryMilitary
    }
}
