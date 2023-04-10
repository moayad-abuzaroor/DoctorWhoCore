using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.Resources
{
    public class AddDoctorResource
    {
        [Column(TypeName = "varchar(10)")]
        public string DoctorNumber { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string DoctorName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime FirstEpisodeDate { get; set; }
        public DateTime LastEpisodeDate { get; set; }
    }
}
