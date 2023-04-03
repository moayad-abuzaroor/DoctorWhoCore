using DoctorWho.Db.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DoctorWhoCoreDbContext _dbContext;
        private Microsoft.EntityFrameworkCore.DbSet<T> table;
        public GenericRepository()
        {
            this._dbContext = new DoctorWhoCoreDbContext();
            table = _dbContext.Set<T>();
        }
        public GenericRepository(DoctorWhoCoreDbContext _dbContext)
        {
            this._dbContext = _dbContext;
            table = _dbContext.Set<T>();
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _dbContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
