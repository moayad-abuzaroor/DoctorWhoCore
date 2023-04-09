using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Persistence.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.IServices
{
    public interface IAuthorServices
    {
        IEnumerable<Author> GetAllAuthors();
        Author GetAuthorById(int id);
        AuthorResponse InsertAuthor(Author author);
        AuthorResponse DeleteAuthor(int id);
        AuthorResponse UpdateAuthor(int id, Author author);
    }
}
