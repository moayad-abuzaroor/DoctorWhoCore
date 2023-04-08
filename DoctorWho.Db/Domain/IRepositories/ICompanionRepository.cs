using DoctorWho.Db.Domain.Functions;
using DoctorWho.Db.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.IRepositories
{
    public interface ICompanionRepository
    {
        void AddCompanion(string companionName, string whoPlayed);
        void UpdateCompanion(int id, string companionName, string whoPlayed);
        void DeleteCompanion(int id);
        List<Companion> GetCompanionById(int id);
        List<fnCompanionClass> companionFunctionClass(int episodeId);
    }
}
