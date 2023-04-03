using DoctorWho.Db.Functions;
using DoctorWho.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.IRepositories
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
