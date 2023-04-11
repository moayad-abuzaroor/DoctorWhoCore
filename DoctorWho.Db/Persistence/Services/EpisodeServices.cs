using DoctorWho.Db.Domain.IRepositories;
using DoctorWho.Db.Domain.IServices;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Persistence.Repositories;
using DoctorWho.Db.Persistence.Services.Communication;
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
        IGenericRepository<Companion> repoCompanion = new GenericRepository<Companion>();
        IGenericRepository<Enemy> repoEnemy = new GenericRepository<Enemy>();

        public EpisodeResponse AddCompanionToEpisode(int companionId, int episodeId)
        {
            var existingEpisode = repoEpisode.GetById(episodeId);
            if (existingEpisode == null)
                return new EpisodeResponse("Episode not found");

            var existingCompanion = repoCompanion.GetById(companionId);
            if (existingCompanion == null)
                return new EpisodeResponse("Companion not found");

            try
            {
                repoEpisode2.AddCompanionToEpisode(companionId, episodeId);
                repoEpisode.Save();

                return new EpisodeResponse(existingEpisode);
            }
            catch (Exception ex)
            {
                return new EpisodeResponse($"An error occurred when trying to add companion to an episode");
            }
        }

        public EpisodeResponse AddEnemyToEpisode(int enemyId, int episodeId)
        {
            var existingEpisode = repoEpisode.GetById(episodeId);
            if (existingEpisode == null)
                return new EpisodeResponse("Episode not found");

            var existingEnemy = repoEnemy.GetById(enemyId);
            if (existingEnemy == null)
                return new EpisodeResponse("Enemy not found");

            try
            {
                repoEpisode2.AddEnemyToEpisode(enemyId, episodeId);
                repoEpisode.Save();

                return new EpisodeResponse(existingEpisode);
            }
            catch (Exception ex)
            {
                return new EpisodeResponse($"An error occurred when trying to add enemy to an episode");
            }
        }

        public EpisodeResponse DeleteEpisode(int id)
        {
            var existingEpisode = repoEpisode.GetById(id);
            if (existingEpisode == null)
                return new EpisodeResponse("Episode not found");

            try
            {
                repoEpisode.Delete(id);
                repoEpisode.Save();

                return new EpisodeResponse(existingEpisode);
            }
            catch(Exception ex)
            {
                return new EpisodeResponse($"An error occurred when deleting Episode: {ex.Message}");
            }
        }

        public IEnumerable<Episode> GetAllEpisodes()
        {
            return repoEpisode.GetAll();
        }

        public Episode GetEpisodeById(int id)
        {
            return repoEpisode.GetById(id);
        }

        public EpisodeResponse InsertEpisode(Episode episode)
        {
            try
            {
                repoEpisode.Insert(episode);
                repoEpisode.Save();

                return new EpisodeResponse(episode);
            }
            catch(Exception ex)
            {
                return new EpisodeResponse($"An error occurred when adding Episode: {ex.Message}");
            }
        }

        public EpisodeResponse UpdateEpisode(int id, Episode episode)
        {
            var existingEpisode = repoEpisode.GetById(id);
            if (existingEpisode == null)
                return new EpisodeResponse("Episode not found");

            existingEpisode.Title = episode.Title;

            try
            {
                repoEpisode.Update(existingEpisode);
                repoEpisode.Save();

                return new EpisodeResponse(existingEpisode);
            }
            catch (Exception ex)
            {
                return new EpisodeResponse($"An error occurred when updating Episode: {ex.Message}");
            }
        }
    }
}
