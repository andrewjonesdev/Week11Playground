namespace Week11Playground.Models.Entities
{
    public class MemberSkill
    {
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
