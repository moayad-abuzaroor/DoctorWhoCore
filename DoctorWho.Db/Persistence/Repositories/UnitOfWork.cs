using DoctorWho.Db.Domain.IRepositories;
using DoctorWho.Db.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DoctorWhoCoreDbContext _dbContext;
        public UnitOfWork(DoctorWhoCoreDbContext context)
        {
            _dbContext = context;
        }
        public async Task Complete()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
