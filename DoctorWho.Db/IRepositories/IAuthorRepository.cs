using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.IRepositories
{
    public interface IAuthorRepository
    {
        void AddAuthor(string authorName);
        void UpdateAuthor(int id, string authorName);
        void DeleteAuthor(int id);
    }
}
