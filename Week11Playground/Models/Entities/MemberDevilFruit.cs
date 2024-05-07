namespace Week11Playground.Models.Entities
{
    public class MemberDevilFruit
    {
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
        public Guid DevilFruitId { get; set; }
        public DevilFruit DevilFruit { get; set; }
    }
}
