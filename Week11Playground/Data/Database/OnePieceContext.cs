using Microsoft.EntityFrameworkCore;
using Week11Playground.Data.Database.Interfaces;
using Week11Playground.Models.Entities;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Week11Playground.Data.Database
{
    public class OnePieceContext : DbContext, IUnitOfWork
    {
        public OnePieceContext()
        {
        }

        public OnePieceContext(DbContextOptions<OnePieceContext> options) : base(options)
        {
        }

        public DbSet<Member> Members { get; set; } = null!;
        public DbSet<Organization> Organizations { get; set; } = null!;
        public DbSet<DevilFruit> DevilFruits { get; set; } = null!;
        public DbSet<Weapon> Weapons { get; set; } = null!;
        public DbSet<Skill> Skills { get; set; } = null!;
        public DbSet<MemberDevilFruit> MemberDevilFruits { get; set; } = null!;
        public DbSet<MemberSkill> MemberSkills { get; set; } = null!;
        public DbSet<MemberWeapon> MemberWeapons { get; set; } = null!;
        public DbSet<DevilFruitWeapon> DevilFruitWeapons { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                .Property(m => m.Designation)
                .HasConversion<string>();

            modelBuilder.Entity<Member>()
                .Property(m => m.CurrentLocation)
                .HasConversion<string>();

            modelBuilder.Entity<Member>()
                .Property(m => m.PlaceOfBirth)
                .HasConversion<string>();

            modelBuilder.Entity<Organization>()
                .Property(o => o.OrganizationTypeId)
                .HasConversion<string>();

            modelBuilder.Entity<Weapon>()
                .Property(w => w.WeaponGradeId)
                .HasConversion<string>();

            modelBuilder.Entity<DevilFruit>()
                .Property(d => d.DevilFruitTypeId)
                .HasConversion<string>();

            modelBuilder.Entity<Skill>()
                .Property(s => s.Name)
                .HasConversion<string>();

            modelBuilder.Entity<Member>()
                .HasOne<Organization>(m => m.Organization)
                .WithMany(o => o.Members)
                .HasForeignKey(m => m.OrganizationId);

            modelBuilder.Entity<MemberDevilFruit>().HasKey(mdf => new { mdf.MemberId, mdf.DevilFruitId });

            modelBuilder.Entity<MemberSkill>().HasKey(ms => new { ms.MemberId, ms.SkillId });

            modelBuilder.Entity<MemberWeapon>().HasKey(mw => new { mw.MemberId, mw.WeaponId });

            modelBuilder.Entity<DevilFruitWeapon>().HasKey(dfw => new { dfw.DevilFruitId, dfw.WeaponId });
        }
    }
}
