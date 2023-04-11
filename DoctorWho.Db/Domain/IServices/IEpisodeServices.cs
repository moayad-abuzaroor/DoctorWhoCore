using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Persistence.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.IServices
{
    public interface IEpisodeServices
    {
        IEnumerable<Episode> GetAllEpisodes();
        Episode GetEpisodeById(int id);
        EpisodeResponse InsertEpisode(Episode episode);
        EpisodeResponse UpdateEpisode(int id, Episode episode);
        EpisodeResponse DeleteEpisode(int id);
        EpisodeResponse AddEnemyToEpisode(int enemyId, int episodeId);
        EpisodeResponse AddCompanionToEpisode(int companionId, int episodeId);
    }
}
