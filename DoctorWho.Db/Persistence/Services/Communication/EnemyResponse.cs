using DoctorWho.Db.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Persistence.Services.Communication
{
    public class EnemyResponse : BaseResponse
    {
        public Enemy Enemy { get; set; }
        public EnemyResponse(bool success, string message, Enemy enemy) : base(success, message)
        {
            Enemy = enemy;
        }
        public EnemyResponse(Enemy enemy) : this(true, string.Empty, enemy) { }        
        public EnemyResponse(string message) : this(false, message, null) { }
        
    }
}
