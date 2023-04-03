using DoctorWho.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.IServices
{
    public interface IAuthorServices
    {
        IEnumerable<Author> GetAllAuthors();
        Author GetAuthorById(int id);
        void InsertAuthor(Author author);
        void DeleteAuthor(int id);
        void UpdateAuthor(Author author);
    }
}
