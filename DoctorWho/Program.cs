using DoctorWho.Db;
using DoctorWho.Db.Functions;
using DoctorWho.Db.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Infrastructure;
using DoctorWho.Db.Views;
using static Azure.Core.HttpHeader;

namespace DoctorWho
{
    public class Program {
        static void Main(string[] args) {
            var fnCompanions = companionFunctionClass();
            Console.WriteLine("----------------");
            var fnEnemies = enemiesFunctionClass();
            Console.WriteLine("----------------");
            //var viewEpisodes = viewEpisodesClass();
            Console.WriteLine("----------------");
            //AddEnemyToEpisode(4, 5);
            //AddCompanionToEpisode(3, 4);
            //var getAllDoctors = GetAllDoctors();
            //var getEnemyById = GetEnemyById(4);
            
        }

        private static List<fnCompanionClass> companionFunctionClass() {
            int count = 1;
            var context = new DoctorWhoCoreDbContext();
            var query = from c in context.fnCompanions(1) select c;
            foreach(var c in query) {
                Console.WriteLine($"Companion {count} Name: {c.CompanionName}");
                count++;
            }
            return query.ToList();
        }
        private static List<fnEnemiesClass> enemiesFunctionClass() {
            var context = new DoctorWhoCoreDbContext();
            var query = from e in context.fnEnemies(1) select e;
            foreach (var e in query) {
                Console.WriteLine($"Enemy Name: {e.EnemyName}");
            }
            return query.ToList();
        }
        
        private static List<viewEpisodes> viewEpisodesClass() {
            var context = new DoctorWhoCoreDbContext();
            var query = from v in context.viewEpisodes select v;
            Console.WriteLine($"Episode Id\tAuthor Name\tDoctor Name\t\tCompanion Name\tEnemy Name");
            foreach (var v in query) {                
                Console.WriteLine(v.EpisodeId+"\t\t"+v.AuthorName +
                    "\t" + v.DoctorName + "\t" + v.CompanionName + "\t" + v.EnemyName);
            }
            return query.ToList();
        }

        private static void AddCompanion(string companionName, string whoPlayed) {
            var context = new DoctorWhoCoreDbContext();
            Companion newCompanion = new Companion() {
                CompanionName = companionName,
                WhoPlayed = whoPlayed
            };
            context.Add(newCompanion);
            context.SaveChanges();
            /*var query = from c in context.tblCompanion select c;
            foreach(var c in query) {
                Console.WriteLine(c.CompanionName);
            }*/
        }

        private static void UpdateCompanion(int id, string companionName, string whoPlayed) {
            var context = new DoctorWhoCoreDbContext();
            Companion updateCompanion;
            updateCompanion = context.tblCompanion.Where(c => c.CompanionId == id).First();
            updateCompanion.CompanionName = companionName;
            updateCompanion.WhoPlayed = whoPlayed;
            context.SaveChanges();
            /*var query = from c in context.tblCompanion select c;
            foreach (var c in query) {
                Console.WriteLine(c.CompanionName);
            }*/
        }

        private static void DeleteCompanion(int id) {
            var context = new DoctorWhoCoreDbContext();
            Companion deleteCompanion;
            deleteCompanion = context.tblCompanion.Where(c => c.CompanionId == id).First();
            context.Remove(deleteCompanion);
            context.SaveChanges();
            /*var query = from c in context.tblCompanion select c;
            foreach(var c in query) {
                Console.WriteLine(c.CompanionName);
            }*/
        }

        private static void AddEnemy(string enemyName, string description) {
            var context = new DoctorWhoCoreDbContext();
            Enemy newEnemy = new Enemy() {
                EnemyName = enemyName,
                Description = description
            };
            context.Add(newEnemy); 
            context.SaveChanges();
            /*var query = from e in context.tblEnemy select e;
            foreach (var e in query) {
                Console.WriteLine(e.EnemyName);
            }*/
        }

        private static void UpdateEnemy(int id, string enemyName, string description) {
            var context = new DoctorWhoCoreDbContext();
            Enemy updateEnemy;
            updateEnemy = context.tblEnemy.Where(e => e.EnemyId == id).First();
            updateEnemy.EnemyName = enemyName;
            updateEnemy.Description = description; 
            context.SaveChanges();
            /*var query = from e in context.tblEnemy select e;
            foreach (var e in query) {
                Console.WriteLine(e.EnemyName);
            }*/
        }

        private static void DeleteEnemy(int id) {
            var context = new DoctorWhoCoreDbContext();
            Enemy deleteEnemy;
            deleteEnemy = context.tblEnemy.Where(e => e.EnemyId == id).First();
            context.Remove(deleteEnemy);
            context.SaveChanges();
            /*var query = from e in context.tblEnemy select e;
            foreach(var e in query) {
                Console.WriteLine(e.EnemyName);
            }*/
        }

        private static void AddDoctor(string doctorNumber, string doctorName,
            DateTime birthDate, DateTime firstEpisodeDate, DateTime lastEpisodeDate)
        {
            var context = new DoctorWhoCoreDbContext();
            Doctor newDoctor = new Doctor() {
                DoctorNumber = doctorNumber,
                DoctorName = doctorName,
                BirthDate = birthDate,
                FirstEpisodeDate = firstEpisodeDate,
                LastEpisodeDate = lastEpisodeDate
            };
            context.Add(newDoctor);
            context.SaveChanges();
        }

        private static void UpdateDoctor(int id, string doctorNumber, string doctorName,
            DateTime birthDate, DateTime firstEpisodeDate, DateTime lastEpisodeDate) 
        {
            var context = new DoctorWhoCoreDbContext();
            Doctor updateDoctor;
            updateDoctor = context.tblDoctor.Where(d => d.DoctorId == id).First();
            updateDoctor.DoctorNumber = doctorNumber;
            updateDoctor.DoctorName = doctorName;
            updateDoctor.BirthDate = birthDate;
            updateDoctor.FirstEpisodeDate = firstEpisodeDate;
            updateDoctor.LastEpisodeDate = lastEpisodeDate;

            context.SaveChanges();
        }

        private static void DeleteDoctor(int id) {
            var context = new DoctorWhoCoreDbContext();
            Doctor deleteDoctor;
            deleteDoctor = context.tblDoctor.Where(d => d.DoctorId == id).First();
            context.Remove(deleteDoctor);
            context.SaveChanges();
        }

        private static void AddAuthor(string authorName) {
            var context = new DoctorWhoCoreDbContext();
            Author newAuthor = new Author() {
                AuthorName = authorName
            };
            context.Add(newAuthor);
            context.SaveChanges();
        }

        private static void UpdateAuthor(int id, string authorName) {
            var context = new DoctorWhoCoreDbContext();
            Author updateAuthor;
            updateAuthor = context.tblAuthor.Where(a => a.AuthorId == id).First();
            updateAuthor.AuthorName = authorName;
            context.SaveChanges();
        }

        private static void DeleteAuthor(int id) {
            var context = new DoctorWhoCoreDbContext();
            Author deleteAuthor;
            deleteAuthor = context.tblAuthor.Where(a => a.AuthorId == id).First();
            context.Remove(deleteAuthor);
            context.SaveChanges();
        }

        private static void AddEpisode(int seriesNumber, int episodeNumber, string episodeType,
            string title, DateTime episodeDate, int authorId, int doctorId, string notes) 
        {
            var context = new DoctorWhoCoreDbContext();
            Episode newEpisode = new Episode() {
                SeriesNumber = seriesNumber,
                EpisodeNumber = episodeNumber,
                EpisodeType = episodeType,
                Title = title,
                EpisodeDate = episodeDate,
                AuthorId = authorId,
                DoctorId = doctorId,
                Notes = notes
            };
            context.Add(newEpisode);
            context.SaveChanges();
        }

        private static void UpdateEpisode(int id, int seriesNumber, int episodeNumber, string episodeType,
            string title, DateTime episodeDate, int authorId, int doctorId, string notes) 
        {
            var context = new DoctorWhoCoreDbContext();
            Episode updateEpisode;
            updateEpisode = context.tblEpisode.Where(e => e.EpisodeId == id).First();
            updateEpisode.SeriesNumber = seriesNumber;
            updateEpisode.EpisodeNumber = episodeNumber;
            updateEpisode.EpisodeType = episodeType;
            updateEpisode.Title = title;
            updateEpisode.EpisodeDate = episodeDate;
            updateEpisode.AuthorId = authorId;
            updateEpisode.DoctorId = doctorId;
            updateEpisode.Notes = notes;

            context.SaveChanges();
        }

        private static void DeleteEpisode(int id) {
            var context = new DoctorWhoCoreDbContext();
            Episode deleteEpisode;
            deleteEpisode = context.tblEpisode.Where(e => e.EpisodeId == id).First();
            context.Remove(deleteEpisode);
            context.SaveChanges();
        }

        private static void AddEnemyToEpisode(int enemyId, int episodeId) {
            var context = new DoctorWhoCoreDbContext();
            EpisodeEnemy episodeEnemy = new EpisodeEnemy() {
                EnemyId = enemyId,
                EpisodeId = episodeId
            };
            context.Add(episodeEnemy);
            context.SaveChanges();
        }

        private static void AddCompanionToEpisode(int companionId, int episodeId) {
            var context = new DoctorWhoCoreDbContext();
            EpisodeCompanion episodeCompanion = new EpisodeCompanion() {
                CompanionId = companionId,
                EpisodeId = episodeId
            };
            context.Add(episodeCompanion);
            context.SaveChanges();
        }

        private static List<Doctor> GetAllDoctors() {
            var context = new DoctorWhoCoreDbContext();
            var query = from d in context.tblDoctor select d;
            return query.ToList();
        }

        private static List<Enemy> GetEnemyById(int id) {
            var context = new DoctorWhoCoreDbContext();
            var query = from e in context.tblEnemy
                        where e.EnemyId == id
                        select e;
            return query.ToList();
        }
    }
}
