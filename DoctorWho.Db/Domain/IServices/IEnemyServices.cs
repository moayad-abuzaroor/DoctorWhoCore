using DoctorWho.Db.Domain.Functions;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Persistence.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.IServices
{
    public interface IEnemyServices
    {
        IEnumerable<Enemy> GetAllEnemies();
        Enemy GetEnemyById(int id);
        EnemyResponse InsertEnemy(Enemy enemy);
        EnemyResponse UpdateEnemy(int id, Enemy enemy);
        EnemyResponse DeleteEnemy(int id);
        List<fnEnemiesClass> GetEnemiesByEpisodeId(int episodeId);
    }
}
