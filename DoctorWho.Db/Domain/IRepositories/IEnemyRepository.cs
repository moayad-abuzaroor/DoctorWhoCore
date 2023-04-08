using DoctorWho.Db.Domain.Functions;
using DoctorWho.Db.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.IRepositories
{
    public interface IEnemyRepository
    {
        void AddEnemy(string enemyName, string description);
        void UpdateEnemy(int id, string enemyName, string description);
        void DeleteEnemy(int id);
        List<fnEnemiesClass> enemiesFunctionClass(int episodeId);
        List<Enemy> GetEnemyById(int id);
    }
}
