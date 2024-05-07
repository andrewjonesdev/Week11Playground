using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Week11Playground.Models.Entities;

namespace Week11Playground.Data.Database.Interfaces;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    DbSet<Member> Members { get; }
    DbSet<Organization> Organizations { get; }
    DbSet<DevilFruit> DevilFruits { get; }
    DbSet<Weapon> Weapons { get; }
    DbSet<Skill> Skills { get; }
    DbSet<MemberDevilFruit> MemberDevilFruits { get; }
    DbSet<MemberSkill> MemberSkills { get; }
    DbSet<MemberWeapon> MemberWeapons { get; }
    DbSet<DevilFruitWeapon> DevilFruitWeapons { get; }
}