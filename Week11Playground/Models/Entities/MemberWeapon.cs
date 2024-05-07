namespace Week11Playground.Models.Entities
{
    public class MemberWeapon
    {
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
        public Guid WeaponId { get; set; }
        public Weapon Weapon { get; set; }
    }
}
