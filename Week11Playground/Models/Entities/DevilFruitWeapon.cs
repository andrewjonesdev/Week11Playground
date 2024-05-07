namespace Week11Playground.Models.Entities
{
    public class DevilFruitWeapon
    {
        public Guid DevilFruitId { get; set; }
        public DevilFruit DevilFruit { get; set; }
        public Guid WeaponId { get; set; }
        public Weapon Weapon { get; set; }
    }
}
