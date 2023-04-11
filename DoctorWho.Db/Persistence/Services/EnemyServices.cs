using DoctorWho.Db.Domain.Functions;
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
    public class EnemyServices : IEnemyServices
    {
        IGenericRepository<Enemy> repoEnemy = new GenericRepository<Enemy>();
        IEnemyRepository repoEnemy2 = new EnemyRepository();
        public EnemyResponse DeleteEnemy(int id)
        {
            var existingEnemy = repoEnemy.GetById(id);
            if (existingEnemy == null)
                return new EnemyResponse("Enemy not found");

            try
            {
                repoEnemy.Delete(id);
                repoEnemy.Save();

                return new EnemyResponse(existingEnemy);
            }
            catch (Exception ex)
            {
                return new EnemyResponse($"An error occurred when deleting Enemy: {ex.Message}");
            }
        }

        public IEnumerable<Enemy> GetAllEnemies()
        {
            return repoEnemy.GetAll();
        }

        public List<fnEnemiesClass> GetEnemiesByEpisodeId(int episodeId)
        {
            return repoEnemy2.enemiesFunctionClass(episodeId);
        }

        public Enemy GetEnemyById(int id)
        {
            return repoEnemy.GetById(id);
        }

        public EnemyResponse InsertEnemy(Enemy enemy)
        {
            try
            {
                repoEnemy.Insert(enemy);
                repoEnemy.Save();

                return new EnemyResponse(enemy);
            }
            catch(Exception ex)
            {
                return new EnemyResponse($"An error occurred when adding Enemy: {ex.Message}");
            }
        }

        public EnemyResponse UpdateEnemy(int id, Enemy enemy)
        {
            var existingEnemy = repoEnemy.GetById(id);
            if (existingEnemy == null)
                return new EnemyResponse("Enemy not found");

            existingEnemy.EnemyName = enemy.EnemyName;
            existingEnemy.Description = enemy.Description;

            try
            {
                repoEnemy.Update(existingEnemy);
                repoEnemy.Save();

                return new EnemyResponse(existingEnemy);
            }
            catch (Exception ex)
            {
                return new EnemyResponse($"An error occurred when updating Enemy: {ex.Message}");
            }
        }
    }
}
