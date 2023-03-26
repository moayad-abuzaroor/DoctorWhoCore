using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Models {
    public class Enemy {

        [ForeignKey("EpisodeEnemy")]
        public int EnemyId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string EnemyName { get; set; }
        public string Description { get; set; }
    }
}
