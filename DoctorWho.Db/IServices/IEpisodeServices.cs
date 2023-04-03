using DoctorWho.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.IServices
{
    public interface IEpisodeServices
    {
        IEnumerable<Episode> GetAllEpisodes();
        Episode GetEpisodeById(int id);
        void InsertEpisode(Episode episode);
        void UpdateEpisode(Episode episode);
        void DeleteEpisode(int id);
        void AddEnemyToEpisode(int enemyId, int episodeId);
        void AddCompanionToEpisode(int companionId, int episodeId);
    }
}
