using DoctorWho.Db.Domain.Functions;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Domain.IRepositories;
using DoctorWho.Db.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoctorWho.Db.Persistence.Services.Communication;

namespace DoctorWho.Db.Domain.IServices
{
    public interface ICompanionServices
    {
        IEnumerable<Companion> GetAllCompanions();
        Companion GetCompanionById(int id);
        CompanionResponse InsertCompanion(Companion companion);
        CompanionResponse DeleteCompanion(int id);
        CompanionResponse UpdateCompanion(int id, Companion companion);
        List<fnCompanionClass> GetCompanionsByEpisodeId(int episodeId);
    }
}
