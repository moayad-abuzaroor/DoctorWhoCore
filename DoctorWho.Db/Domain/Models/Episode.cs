using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.Models
{
    public class Episode
    {

        [ForeignKey("EpisodeEnemy, EpisodeCompanion")]
        public int EpisodeId { get; set; }
        public int SeriesNumber { get; set; }
        public int EpisodeNumber { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string EpisodeType { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Title { get; set; }
        public DateTime EpisodeDate { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public string Notes { get; set; }
    }
}
