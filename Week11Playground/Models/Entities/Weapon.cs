using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Week11Playground.Enums;

namespace Week11Playground.Models.Entities
{
    public class Weapon
    {
        [Key] public Guid WeaponId { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "varchar(255)")]
        [JsonConverter(typeof(StringEnumConverter))]
        public WeaponGradeId WeaponGradeId { get; set; }
        public string MakerName { get; set; }
        public bool IsBlackWeapon { get; set; }
        public bool IsCursed { get; set; }
        public string WeaponSeries { get; set; }
        public Guid DevilFruitId { get; set; }
        public IList<Member> Members { get; set; }
        public IList<DevilFruit> DevilFruits { get; set; }
    }
}
