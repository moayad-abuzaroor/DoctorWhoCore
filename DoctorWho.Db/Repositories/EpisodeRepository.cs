using DoctorWho.Db.Models;
using DoctorWho.Db.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories {
    public class EpisodeRepository {
        public List<viewEpisodes> viewEpisodesClass() {
            var context = new DoctorWhoCoreDbContext();
            var query = from v in context.viewEpisodes select v;
            Console.WriteLine($"Episode Id\tAuthor Name\tDoctor Name\t\tCompanion Name\tEnemy Name");
            foreach (var v in query) {
                Console.WriteLine(v.EpisodeId + "\t\t" + v.AuthorName +
                    "\t" + v.DoctorName + "\t" + v.CompanionName + "\t" + v.EnemyName);
            }
            return query.ToList();
        }

        public void AddEpisode(int seriesNumber, int episodeNumber, string episodeType,
            string title, DateTime episodeDate, int authorId, int doctorId, string notes) {
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

        public void UpdateEpisode(int id, int seriesNumber, int episodeNumber, string episodeType,
            string title, DateTime episodeDate, int authorId, int doctorId, string notes) {
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

        public void DeleteEpisode(int id) {
            var context = new DoctorWhoCoreDbContext();
            Episode deleteEpisode;
            deleteEpisode = context.tblEpisode.Where(e => e.EpisodeId == id).First();
            context.Remove(deleteEpisode);
            context.SaveChanges();
        }

        public void AddEnemyToEpisode(int enemyId, int episodeId) {
            var context = new DoctorWhoCoreDbContext();
            EpisodeEnemy episodeEnemy = new EpisodeEnemy() {
                EnemyId = enemyId,
                EpisodeId = episodeId
            };
            context.Add(episodeEnemy);
            context.SaveChanges();
        }

        public void AddCompanionToEpisode(int companionId, int episodeId) {
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
