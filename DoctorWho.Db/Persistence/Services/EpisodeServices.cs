using DoctorWho.Db.Domain.IRepositories;
using DoctorWho.Db.Domain.IServices;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Persistence.Services
{
    public class EpisodeServices : IEpisodeServices
    {
        IGenericRepository<Episode> repoEpisode = new GenericRepository<Episode>();
        IEpisodeRepository repoEpisode2 = new EpisodeRepository();

        public void AddCompanionToEpisode(int companionId, int episodeId)
        {
            repoEpisode2.AddCompanionToEpisode(companionId, episodeId);
        }

        public void AddEnemyToEpisode(int enemyId, int episodeId)
        {
            repoEpisode2.AddEnemyToEpisode(enemyId, episodeId);
        }

        public void DeleteEpisode(int id)
        {
            repoEpisode.Delete(id);
        }

        public IEnumerable<Episode> GetAllEpisodes()
        {
            return repoEpisode.GetAll();
        }

        public Episode GetEpisodeById(int id)
        {
            return repoEpisode.GetById(id);
        }

        public void InsertEpisode(Episode episode)
        {
            repoEpisode.Insert(episode);
        }

        public void UpdateEpisode(Episode episode)
        {
            repoEpisode.Update(episode);
        }
    }
}
