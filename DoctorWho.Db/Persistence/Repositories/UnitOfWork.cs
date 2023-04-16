using DoctorWho.Db.Domain.IRepositories;
using DoctorWho.Db.Domain.Models;
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
        private IGenericRepository<Companion> _companionRepository;
        private ICompanionRepository _companionRepository2;
        public UnitOfWork()
        {
            _dbContext = new DoctorWhoCoreDbContext();            
        }
        public UnitOfWork(DoctorWhoCoreDbContext context, ICompanionRepository companionRepository2
            , IGenericRepository<Companion> companionRepository)
        {
            _dbContext = context;
            _companionRepository2 = companionRepository2;
            _companionRepository = companionRepository;
        }

        public IGenericRepository<Companion> CompanionRepository
        {
            get
            {

                if (_companionRepository == null)
                {
                    _companionRepository = new GenericRepository<Companion>(_dbContext);
                }
                return _companionRepository;
            }
        }
        public ICompanionRepository CompanionRepository2
        {
            get
            {

                if (_companionRepository2 == null)
                {
                    _companionRepository2 = new CompanionRepository(_dbContext);
                }
                return _companionRepository2;
            }
        }

        public void Complete()
        {
            _dbContext.SaveChanges();
        }
    }
}
