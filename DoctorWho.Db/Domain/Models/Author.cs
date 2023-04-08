using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.Models
{
    public class Author
    {

        [ForeignKey("Episode")]
        public int AuthorId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string AuthorName { get; set; }
    }
}
