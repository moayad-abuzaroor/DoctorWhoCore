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
    }
}
