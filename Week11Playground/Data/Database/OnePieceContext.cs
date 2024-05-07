using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Week11Playground.Data.Database.Interfaces;
using Week11Playground.Models.Entities;

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
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Startup.GetAppSettings("OnePieceContext"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                .HasOne<Organization>(m => m.Organization)
                .WithMany(o => o.Members)
                .HasForeignKey(m => m.OrganizationId);

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
