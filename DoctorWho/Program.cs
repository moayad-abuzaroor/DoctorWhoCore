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
using DoctorWho.Db.Repositories;

namespace DoctorWho
{
    public class Program {
        static void Main(string[] args) {

            AuthorRepository author = new AuthorRepository();
            CompanionRepository companion = new CompanionRepository();
            DoctorRepository doctor = new DoctorRepository();
            EnemyRepository enemy = new EnemyRepository();
            Console.WriteLine("----------------");
            //var viewEpisodes = viewEpisodesClass();
            
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

        
    }
}
