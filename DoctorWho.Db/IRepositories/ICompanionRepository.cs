using DoctorWho.Db.Functions;
using DoctorWho.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.IRepositories
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
