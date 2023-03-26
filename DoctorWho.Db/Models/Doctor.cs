using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Models {
    public class Doctor {

        [ForeignKey("Episode")]
        public int DoctorId { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string DoctorNumber { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string DoctorName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime FirstEpisodeDate { get; set; }
        public DateTime LastEpisodeDate { get; set; }

    }
}
