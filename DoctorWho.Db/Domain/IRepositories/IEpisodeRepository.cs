using DoctorWho.Db.Domain.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.IRepositories
{
    public interface IEpisodeRepository
    {
        List<viewEpisodes> viewEpisodesClass();
        void AddEpisode(int seriesNumber, int episodeNumber, string episodeType,
            string title, DateTime episodeDate, int authorId, int doctorId, string notes);
        void UpdateEpisode(int id, int seriesNumber, int episodeNumber, string episodeType,
            string title, DateTime episodeDate, int authorId, int doctorId, string notes);
        void DeleteEpisode(int id);
        void AddEnemyToEpisode(int enemyId, int episodeId);
        void AddCompanionToEpisode(int companionId, int episodeId);
    }
}
