using DoctorWho.Db.Domain.Functions;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Domain.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Persistence.Context
{
    public class DoctorWhoCoreDbContext : DbContext
    {
        public DoctorWhoCoreDbContext()
        {
        }

        public DoctorWhoCoreDbContext(DbContextOptions<DoctorWhoCoreDbContext> options) : base(options)
        { }
        public DbSet<Author> tblAuthor { get; set; }
        public DbSet<Companion> tblCompanion { get; set; }
        public DbSet<Doctor> tblDoctor { get; set; }
        public DbSet<Enemy> tblEnemy { get; set; }
        public DbSet<Episode> tblEpisode { get; set; }
        public DbSet<EpisodeCompanion> tblEpisodeCompanion { get; set; }
        public DbSet<EpisodeEnemy> tblEpisodeEnemy { get; set; }
        public DbSet<viewEpisodes> viewEpisodes { get; set; }


        public IQueryable<fnCompanionClass> fnCompanions(int episodeId)
        => FromExpression(() => fnCompanions(episodeId));

        public IQueryable<fnEnemiesClass> fnEnemies(int episodeId)
        => FromExpression(() => fnEnemies(episodeId));



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-MKSIC0H\\sqlexpress;Initial Catalog=DoctorWhoCore;Integrated Security=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region DoctorSeed
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    DoctorId = 1,
                    DoctorNumber = "1",
                    DoctorName = "William Hartnell",
                    BirthDate = Convert.ToDateTime("1908 - 01 - 08"),
                    FirstEpisodeDate = Convert.ToDateTime("1963 - 10 - 29"),
                    LastEpisodeDate = Convert.ToDateTime("1966 - 10 - 29")
                },
                new Doctor
                {
                    DoctorId = 2,
                    DoctorNumber = "2",
                    DoctorName = "Patrick Troughton",
                    BirthDate = Convert.ToDateTime("1920 - 03 - 25"),
                    FirstEpisodeDate = Convert.ToDateTime("1966 - 11 - 05"),
                    LastEpisodeDate = Convert.ToDateTime("1969 - 06 - 21")
                },
                new Doctor
                {
                    DoctorId = 3,
                    DoctorNumber = "3",
                    DoctorName = "Jon Pertwee",
                    BirthDate = Convert.ToDateTime("1919 - 07 - 07"),
                    FirstEpisodeDate = Convert.ToDateTime("1970 - 01 - 02"),
                    LastEpisodeDate = Convert.ToDateTime("1974 - 06 - 08")
                },
                new Doctor
                {
                    DoctorId = 4,
                    DoctorNumber = "4",
                    DoctorName = "Tom Baker",
                    BirthDate = Convert.ToDateTime("1934 - 01 - 20"),
                    FirstEpisodeDate = Convert.ToDateTime("1974 - 12 - 28"),
                    LastEpisodeDate = Convert.ToDateTime("1981 - 03 - 21")
                },
                new Doctor
                {
                    DoctorId = 5,
                    DoctorNumber = "5",
                    DoctorName = "Jodie Whittaker",
                    BirthDate = Convert.ToDateTime("1982-06-17"),
                    FirstEpisodeDate = Convert.ToDateTime("2018 - 10 - 07"),
                }
            );
            #endregion

            #region AuthorSeed
            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, AuthorName = "Anthony Coburn" },
                new Author { AuthorId = 2, AuthorName = "Terry Nation" },
                new Author { AuthorId = 3, AuthorName = "David Whitaker" },
                new Author { AuthorId = 4, AuthorName = "John Lucarotti" },
                new Author { AuthorId = 5, AuthorName = "Peter R. Newman" }
            );
            #endregion

            #region CompanionSeed
            modelBuilder.Entity<Companion>().HasData(
                new Companion { CompanionId = 1, CompanionName = "Susan Foreman", WhoPlayed = "Carole Ann Ford" },
                new Companion { CompanionId = 2, CompanionName = "Barbara Wright", WhoPlayed = "Jacqueline Hill" },
                new Companion { CompanionId = 3, CompanionName = "Ian Chesterton", WhoPlayed = "William Russell" },
                new Companion { CompanionId = 4, CompanionName = "Vicki", WhoPlayed = "Maureen O'Brien" },
                new Companion { CompanionId = 5, CompanionName = "Steven Taylor", WhoPlayed = "Peter Purves" }
            );
            #endregion

            #region EnemySeed
            modelBuilder.Entity<Enemy>().HasData(
                new Enemy
                {
                    EnemyId = 1,
                    EnemyName = "Daleks",
                    Description = "It landed here way back in the 9th century." +
                    " After a long; deadly battle; The Dalek was defeated." +
                    " It’s casing was destroyed; the creature inside was cut into three pieces so it could" +
                    " never reform. Two were successfully transported away and guarded by the order of the" +
                    " custodians. But one piece was left behind. It stayed in Sheffield; where it was found" +
                    " 12 centuries later and was accidentally woken up. You would think a squiddy thing like" +
                    " that couldn’t get far. But turns out it could hitch a ride on humans. It built it’s own" +
                    " casing from spare parts and bits of it’s original outer shell."
                },
                new Enemy
                {
                    EnemyId = 2,
                    EnemyName = "Krasko",
                    Description = "Krasko was released from prison and travelled back in time to change the past."
                },
                new Enemy
                {
                    EnemyId = 3,
                    EnemyName = "The Eaters of Light",
                    Description = "A mythical Pictish Beast; discovered by the Doctor to be all too real…"
                },
                new Enemy
                {
                    EnemyId = 4,
                    EnemyName = "Hydroflax",
                    Description = "A malevolent cyborg known for ending battles by eating his enemies dead or" +
                    " alive." +
                    " Don’t lose your head!"
                },
                new Enemy
                {
                    EnemyId = 5,
                    EnemyName = "Flemming",
                    Description = "A maitre d’ who can make any problem disappear." +
                    " Even if he has to digest passengers himself."
                }
            );
            #endregion

            #region EpisodeSeed
            modelBuilder.Entity<Episode>().HasData(
                new Episode
                {
                    EpisodeId = 1,
                    SeriesNumber = 1,
                    EpisodeNumber = 1,
                    EpisodeType = "Classic",
                    Title = "An Unearthly Child (An Unearthly Child - Part One)",
                    EpisodeDate = Convert.ToDateTime("1963-11-23"),
                    AuthorId = 1,
                    DoctorId = 1,
                    Notes = ""
                },
                new Episode
                {
                    EpisodeId = 2,
                    SeriesNumber = 1,
                    EpisodeNumber = 2,
                    EpisodeType = "Classic",
                    Title = "The Cave of Skulls (An Unearthly Child - Part Two)",
                    EpisodeDate = Convert.ToDateTime("1963-11-30"),
                    AuthorId = 1,
                    DoctorId = 1,
                    Notes = ""
                },
                new Episode
                {
                    EpisodeId = 3,
                    SeriesNumber = 2,
                    EpisodeNumber = 1,
                    EpisodeType = "Revised",
                    Title = "The Timeless Children",
                    EpisodeDate = Convert.ToDateTime("2020-02-23"),
                    AuthorId = 2,
                    DoctorId = 2,
                    Notes = ""
                },
                new Episode
                {
                    EpisodeId = 4,
                    SeriesNumber = 2,
                    EpisodeNumber = 2,
                    EpisodeType = "Revised",
                    Title = "Ascension of the Cybermen",
                    EpisodeDate = Convert.ToDateTime("2020-03-01"),
                    AuthorId = 2,
                    DoctorId = 2,
                    Notes = ""
                },
                new Episode
                {
                    EpisodeId = 5,
                    SeriesNumber = 3,
                    EpisodeNumber = 1,
                    EpisodeType = "Special",
                    Title = "Revolution of the Daleks",
                    EpisodeDate = Convert.ToDateTime("2021-01-01"),
                    AuthorId = 2,
                    DoctorId = 3,
                    Notes = ""
                }
            );
            #endregion

            #region EpisodeCompanionSeed
            modelBuilder.Entity<EpisodeCompanion>().HasData(
                new EpisodeCompanion { EpisodeCompanionId = 1, EpisodeId = 1, CompanionId = 1 },
                new EpisodeCompanion { EpisodeCompanionId = 2, EpisodeId = 2, CompanionId = 1 },
                new EpisodeCompanion { EpisodeCompanionId = 3, EpisodeId = 1, CompanionId = 2 },
                new EpisodeCompanion { EpisodeCompanionId = 4, EpisodeId = 2, CompanionId = 2 },
                new EpisodeCompanion { EpisodeCompanionId = 5, EpisodeId = 1, CompanionId = 3 }
            );
            #endregion

            #region EpisodeEnemySeed
            modelBuilder.Entity<EpisodeEnemy>().HasData(
                new EpisodeEnemy { EpisodeEnemyId = 1, EpisodeId = 1, EnemyId = 1 },
                new EpisodeEnemy { EpisodeEnemyId = 2, EpisodeId = 2, EnemyId = 1 },
                new EpisodeEnemy { EpisodeEnemyId = 3, EpisodeId = 3, EnemyId = 2 },
                new EpisodeEnemy { EpisodeEnemyId = 4, EpisodeId = 4, EnemyId = 3 },
                new EpisodeEnemy { EpisodeEnemyId = 5, EpisodeId = 5, EnemyId = 5 }
            );
            #endregion

            #region fnCompanions
            modelBuilder.HasDbFunction(typeof(DoctorWhoCoreDbContext)
                .GetMethod(nameof(fnCompanions)))
                .HasName("fnCompanions");

            modelBuilder.Entity<fnCompanionClass>().HasNoKey();
            #endregion

            #region fnEnemies
            modelBuilder.HasDbFunction(typeof(DoctorWhoCoreDbContext)
                .GetMethod(nameof(fnEnemies)))
                .HasName("fnEnemies");

            modelBuilder.Entity<fnEnemiesClass>().HasNoKey();
            #endregion

            #region viewEpisodes
            modelBuilder
            .Entity<viewEpisodes>()
            .ToView(nameof(viewEpisodes))
            .HasNoKey();
            #endregion
        }

    }
}
