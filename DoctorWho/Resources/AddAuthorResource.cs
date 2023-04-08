using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.Resources
{
    public class AddAuthorResource
    {
        [Column(TypeName = "varchar(100)")]
        public string AuthorName { get; set; }
    }
}
