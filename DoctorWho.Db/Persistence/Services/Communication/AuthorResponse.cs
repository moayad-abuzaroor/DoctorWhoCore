using DoctorWho.Db.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Persistence.Services.Communication
{
    public class AuthorResponse : BaseResponse
    {
        public Author Author { get; set; }
        public AuthorResponse(bool success, string message, Author author) : base(success, message)
        {
            Author = author;
        }
        public AuthorResponse(Author author) : this(true, string.Empty, author)
        {
            
        }
        public AuthorResponse(string message) : this(false, message, null)
        {

        }
    }
}
