using DoctorWho.Db.Domain.Functions;
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
    public class EnemyServices : IEnemyServices
    {
        IGenericRepository<Enemy> repoEnemy = new GenericRepository<Enemy>();
        IEnemyRepository repoEnemy2 = new EnemyRepository();
        public void DeleteEnemy(int id)
        {
            repoEnemy.Delete(id);
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

        public void InsertEnemy(Enemy enemy)
        {
            repoEnemy.Insert(enemy);
        }

        public void UpdateEnemy(Enemy enemy)
        {
            repoEnemy.Update(enemy);
        }
    }
}
