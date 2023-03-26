using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Models {
    public class EpisodeEnemy {
        public int EpisodeEnemyId { get; set; }
        public Episode Episode { get; set; }
        public Enemy Enemy { get; set; }
    }
}
