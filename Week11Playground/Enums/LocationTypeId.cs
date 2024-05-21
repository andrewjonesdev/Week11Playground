using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Week11Playground.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LocationTypeId
    {
        NorthBlue,
        EastBlue,
        SouthBlue,
        WestBlue,
        Paradise,
        NewWorld,
        RedLine,
        CalmBelt
         
    }
}
