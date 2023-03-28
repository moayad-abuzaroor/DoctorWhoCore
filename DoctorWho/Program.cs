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
            //AddCompanion("Moayad", "Ibrahim");
            //UpdateCompanion(6, "Moayad Abu Zaroor", "Ibrahim Shalhoub");
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
    }
}
