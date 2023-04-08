using DoctorWho.Db.Domain.IRepositories;
using DoctorWho.Db.Domain.IServices;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Persistence.Services
{
    public class AuthorServices : IAuthorServices
    {
        IGenericRepository<Author> repoAuthor = new Repositories.GenericRepository<Author>();

        public IEnumerable<Author> GetAllAuthors()
        {
            return repoAuthor.GetAll();
        }

        public Author GetAuthorById(int id)
        {
            return repoAuthor.GetById(id);
        }

        public void InsertAuthor(Author author)
        {
            repoAuthor.Insert(author);
            repoAuthor.Save();
        }

        public void UpdateAuthor(Author author)
        {
            repoAuthor.Update(author);
            repoAuthor.Save();
        }

        public void DeleteAuthor(int id)
        {
            repoAuthor.Delete(id);
            repoAuthor.Save();
        }
    }
}
