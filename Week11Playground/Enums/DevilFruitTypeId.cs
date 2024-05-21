using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Week11Playground.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DevilFruitTypeId
    {
        Paramecia,
        SpecialParamecia,
        Logia,
        Zoan,
        AncientZoan,
        MythicalZoan, 
    }
}
