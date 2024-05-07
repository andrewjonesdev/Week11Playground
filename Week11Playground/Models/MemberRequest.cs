using Week11Playground.Enums;
using Week11Playground.Models.Entities;

namespace Week11Playground.Models
{
    public class MemberRequest
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public string Designation { get; set; }
        public string Organization { get; set; }
        public string PlaceOfBirth { get; set; }
        public string CurrentLocation { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<DevilFruit> DevilFruits { get; set; }
        public long Bounty { get; set; } = 0;
    }
}
