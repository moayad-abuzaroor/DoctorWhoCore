﻿using DoctorWho.Db.Functions;
using DoctorWho.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.IServices
{
    public interface IEnemyServices
    {
        IEnumerable<Enemy> GetAllEnemies();
        Enemy GetEnemyById(int id);
        void InsertEnemy(Enemy enemy);
        void UpdateEnemy(Enemy enemy);
        void DeleteEnemy(int id);
        List<fnEnemiesClass> GetEnemiesByEpisodeId(int episodeId);
    }
}