using DoctorWho.Db.Functions;
using DoctorWho.Db.IRepositories;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.IServices
{
    public interface ICompanionServices
    {
        IEnumerable<Companion> GetAllCompanions();
        Companion GetCompanionById(int id);
        void InsertCompanion(Companion companion);
        void DeleteCompanion(int id);
        void UpdateCompanion(Companion companion);
        List<fnCompanionClass> companionFunctionClass(int episodeId);
    }
}
