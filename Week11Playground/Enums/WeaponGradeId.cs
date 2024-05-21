using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Week11Playground.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WeaponGradeId
    {
        SupremeGrade,
        GreatGrade,
        SkillfulGrade,
        Ungraded
    }
}
