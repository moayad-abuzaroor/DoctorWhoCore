using DoctorWho.Db.Domain.Functions;
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
    public class CompanionServices : ICompanionServices
    {
        IGenericRepository<Companion> repoCompanion = new GenericRepository<Companion>();
        ICompanionRepository repoCompanion2 = new CompanionRepository();

        public List<fnCompanionClass> GetCompanionsByEpisodeId(int episodeId)
        {
            return repoCompanion2.companionFunctionClass(episodeId);
        }

        public void DeleteCompanion(int id)
        {
            repoCompanion.Delete(id);
        }

        public IEnumerable<Companion> GetAllCompanions()
        {
            return repoCompanion.GetAll();
        }

        public Companion GetCompanionById(int id)
        {
            return repoCompanion.GetById(id);
        }

        public void InsertCompanion(Companion companion)
        {
            repoCompanion.Insert(companion);
        }

        public void UpdateCompanion(Companion companion)
        {
            repoCompanion.Update(companion);
        }
    }
}
