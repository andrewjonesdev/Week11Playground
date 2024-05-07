using Week11Playground.Models;
using Week11Playground.Models.Entities;
using Week11Playground.Services.Interfaces;

namespace Week11Playground.Services
{
    public class OnePieceService : IOnePieceService
    {
        private readonly IMemberService _memberService;
        private readonly IOrganizationService _organizationService;
        private readonly IDevilFruitService _devilFruitService;
        private readonly IWeaponService _weaponService;
        private readonly IMemberDevilFruitService _memberDevilFruitService;
        private readonly IMemberSkillService _memberSkillService;
        private readonly IMemberWeaponService _memberWeaponService;
        private readonly IDevilFruitWeaponService _devilFruitWeaponService;
        private readonly CancellationTokenSource _internalTokenSource;

        public OnePieceService(IMemberService memberService, IOrganizationService organizationService, IDevilFruitService devilFruitService, IWeaponService weaponService, IMemberDevilFruitService memberDevilFruitService,
            IMemberSkillService memberSkillService, IMemberWeaponService memberWeaponService, IDevilFruitWeaponService devilFruitWeaponService)
        {
            _memberService = memberService;
            _organizationService = organizationService;
            _devilFruitService = devilFruitService;
            _weaponService = weaponService;
            _memberDevilFruitService = memberDevilFruitService;
            _memberSkillService = memberSkillService;
            _memberWeaponService = memberWeaponService;
            _devilFruitWeaponService = devilFruitWeaponService;
            _internalTokenSource = new();
        }

        public async Task AddMember(MemberRequest memberRequest)
        {
            var member = new Member(memberRequest.Name, memberRequest.Rank, memberRequest.Designation, null, memberRequest.PlaceOfBirth, memberRequest.CurrentLocation, null, null, null, memberRequest.Bounty);
            _memberService.AddMember(member);
            await _memberService.SaveChangesAsync();
        }
    }
}
