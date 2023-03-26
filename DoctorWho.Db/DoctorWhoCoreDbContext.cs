﻿using DoctorWho.Db.Models;
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
        }

    }
}
