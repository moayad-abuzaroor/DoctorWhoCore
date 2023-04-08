using DoctorWho.Db.Domain.Functions;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Domain.IRepositories;
using DoctorWho.Db.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.IServices
{
    public interface ICompanionServices
    {
        IEnumerable<Companion> GetAllCompanions();
        Companion GetCompanionById(int id);
        void InsertCompanion(Companion companion);
        void DeleteCompanion(int id);
        void UpdateCompanion(Companion companion);
        List<fnCompanionClass> GetCompanionsByEpisodeId(int episodeId);
    }
}
