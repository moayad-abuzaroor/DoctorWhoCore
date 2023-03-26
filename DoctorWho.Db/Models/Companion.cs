using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Models {
    public class Companion {

        [ForeignKey("EpisodeCompanion")]
        public int CompanionId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string CompanionName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string WhoPlayed { get; set; }
    }
}
