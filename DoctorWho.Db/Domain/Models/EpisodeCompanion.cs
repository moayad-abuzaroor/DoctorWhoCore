using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.Models
{
    public class EpisodeCompanion
    {
        public int EpisodeCompanionId { get; set; }
        public int EpisodeId { get; set; }
        public Episode Episode { get; set; }
        public int CompanionId { get; set; }
        public Companion Companion { get; set; }
    }
}
