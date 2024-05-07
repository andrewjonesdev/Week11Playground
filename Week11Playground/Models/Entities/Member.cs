using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Week11Playground.Enums;

namespace Week11Playground.Models.Entities
{
    public class Member
    {
        [Key] public Guid MemberId { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
        [Column(TypeName = "varchar(255)")]
        public DesignationTypeId Designation { get; set; }
        public Organization? Organization { get; set; }
        public Guid OrganizationId { get; set; }

        [Column(TypeName = "varchar(255)")]
        public LocationTypeId PlaceOfBirth { get; set; }

        [Column(TypeName = "varchar(255)")]
        public LocationTypeId CurrentLocation { get; set; }
        public IList<Skill>? Skills { get; set; }
        public IList<Weapon>? Weapons { get; set; }
        public IList<DevilFruit>? DevilFruits { get; set; }
        public long Bounty { get; set; } = 0;
        public Member(string Name, string Rank, string Designation, Organization Organization, string PlaceOfBirth, string CurrentLocation, List<Skill> Skills, List<Weapon> Weapons, List<DevilFruit> DevilFruits, long Bounty)
        {
            MemberId = new();
            this.Name = Name;
            this.Rank = Rank;
            this.Designation = (DesignationTypeId)Enum.Parse(typeof(DesignationTypeId), Designation);
            this.Organization = Organization;
            this.PlaceOfBirth = (LocationTypeId)Enum.Parse(typeof(LocationTypeId), PlaceOfBirth);
            this.CurrentLocation = (LocationTypeId)Enum.Parse(typeof(LocationTypeId), CurrentLocation);
            this.Skills = Skills;
            this.Weapons = Weapons;
            this.DevilFruits = DevilFruits;
            this.Bounty = Bounty;
        }

    }
}
