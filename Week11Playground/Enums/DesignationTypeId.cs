using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Week11Playground.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DesignationTypeId
    {
        Cook,
        Shipwright      ,
        Musician,
        Navigator,
        Doctor,
        Scientist,
        Archaeologist,
        Helmsman,
        Intel,
        CabinBoy,
        Chronicler,
        Blacksmith,
        Tailor,
        Scholar,
        Pet,
        Merchant,
        QuarterMaster
    }
}
