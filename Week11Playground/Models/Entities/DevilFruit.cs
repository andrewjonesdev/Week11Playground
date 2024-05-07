using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Week11Playground.Enums;

namespace Week11Playground.Models.Entities
{
    public class DevilFruit
    {
        [Key] public Guid DevilFruitId { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "varchar(255)")]
        public DevilFruitTypeId DevilFruitTypeId { get; set; }
        public bool IsManMade { get; set; }
        public IList<Member> Members { get; set; }
        public IList<Weapon> Weapons { get; set; }
    }
}
