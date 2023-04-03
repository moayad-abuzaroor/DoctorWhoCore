using DoctorWho.Db.IRepositories;
using DoctorWho.Db.IServices;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Services
{
    public class AuthorServices : IAuthorServices
    {
        IGenericRepository<Author> repoAuthor = new GenericRepository<Author>();        

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
        }

        public void UpdateAuthor(Author author)
        {
            repoAuthor.Update(author);
        }

        public void DeleteAuthor(int id)
        {
            repoAuthor.Delete(id);
        }
    }
}
