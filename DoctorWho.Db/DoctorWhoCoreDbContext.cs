using DoctorWho.Db.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db {
    public class DoctorWhoCoreDbContext : DbContext {
        public DbSet<Author> tblAuthor { get; set; }
        public DbSet<Companion> tblCompanion { get; set; }
        public DbSet<Doctor> tblDoctor { get; set; }
        public DbSet<Enemy> tblEnemy { get; set; }
        public DbSet<Episode> tblEpisode { get; set; }
        public DbSet<EpisodeCompanion> tblEpisodeCompanion { get; set; }
        public DbSet<EpisodeEnemy> tblEpisodeEnemy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-MKSIC0H\\sqlexpress;Initial Catalog=DoctorWhoCore;Integrated Security=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            #region DoctorSeed
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor {
                    DoctorId = 1,
                    DoctorNumber = "1",
                    DoctorName = "William Hartnell",
                    BirthDate = Convert.ToDateTime("1908 - 01 - 08"),
                    FirstEpisodeDate = Convert.ToDateTime("1963 - 10 - 29"),
                    LastEpisodeDate = Convert.ToDateTime("1966 - 10 - 29")
                },
                new Doctor {
                    DoctorId = 2,
                    DoctorNumber = "2",
                    DoctorName = "Patrick Troughton",
                    BirthDate = Convert.ToDateTime("1920 - 03 - 25"),
                    FirstEpisodeDate = Convert.ToDateTime("1966 - 11 - 05"),
                    LastEpisodeDate = Convert.ToDateTime("1969 - 06 - 21")
                },
                new Doctor {
                    DoctorId = 3,
                    DoctorNumber = "3",
                    DoctorName = "Jon Pertwee",
                    BirthDate = Convert.ToDateTime("1919 - 07 - 07"),
                    FirstEpisodeDate = Convert.ToDateTime("1970 - 01 - 02"),
                    LastEpisodeDate = Convert.ToDateTime("1974 - 06 - 08")
                },
                new Doctor {
                    DoctorId = 4,
                    DoctorNumber = "4",
                    DoctorName = "Tom Baker",
                    BirthDate = Convert.ToDateTime("1934 - 01 - 20"),
                    FirstEpisodeDate = Convert.ToDateTime("1974 - 12 - 28"),
                    LastEpisodeDate = Convert.ToDateTime("1981 - 03 - 21")
                },
                new Doctor {
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
                new Enemy {
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
                new Enemy {
                    EnemyId = 2,
                    EnemyName = "Krasko",
                    Description = "Krasko was released from prison and travelled back in time to change the past."
                },
                new Enemy {
                    EnemyId = 3,
                    EnemyName = "The Eaters of Light",
                    Description = "A mythical Pictish Beast; discovered by the Doctor to be all too real…"
                },
                new Enemy {
                    EnemyId = 4,
                    EnemyName = "Hydroflax",
                    Description = "A malevolent cyborg known for ending battles by eating his enemies dead or" +
                    " alive." +
                    " Don’t lose your head!"
                },
                new Enemy {
                    EnemyId = 5,
                    EnemyName = "Flemming",
                    Description = "A maitre d’ who can make any problem disappear." +
                    " Even if he has to digest passengers himself."
                }
            );
            #endregion


        }

    }
}
