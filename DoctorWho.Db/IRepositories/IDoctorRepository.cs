using DoctorWho.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.IRepositories
{
    public interface IDoctorRepository
    {
        void AddDoctor(string doctorNumber, string doctorName,
            DateTime birthDate, DateTime firstEpisodeDate, DateTime lastEpisodeDate);
        void UpdateDoctor(int id, string doctorNumber, string doctorName,
            DateTime birthDate, DateTime firstEpisodeDate, DateTime lastEpisodeDate);
        void DeleteDoctor(int id);
        List<Doctor> GetAllDoctors();
    }
}
