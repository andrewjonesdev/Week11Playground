using Week11Playground.Enums;

namespace Week11Playground.Models.Entities
{
    public class Skill
    {
        public SkillTypeId Name { get; set; }
        public Guid SkillId { get; set; }
        public IList<Member> Members { get; set; }
    }
}
