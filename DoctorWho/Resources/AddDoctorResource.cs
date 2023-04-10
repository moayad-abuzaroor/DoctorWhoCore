using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.Resources
{
    public class AddDoctorResource
    {
        public string DoctorNumber { get; set; }
        public string DoctorName { get; set; }
        public string BirthDate { get; set; }
        public string FirstEpisodeDate { get; set; }
        public string LastEpisodeDate { get; set; }
    }
}
