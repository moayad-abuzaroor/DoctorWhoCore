using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.Functions
{
    public class fnEnemiesClass
    {
        public fnEnemiesClass(string enemyName)
        {
            EnemyName = enemyName;
        }

        public string EnemyName { get; set; }
    }
}
