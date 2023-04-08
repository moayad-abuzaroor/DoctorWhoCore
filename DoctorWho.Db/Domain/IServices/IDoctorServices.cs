using DoctorWho.Db.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Domain.IServices
{
    public interface IDoctorServices
    {
        IEnumerable<Doctor> GetAllDoctors();
        Doctor GetDoctorById(int id);
        void InsertDoctor(Doctor doctor);
        void UpdateDoctor(Doctor doctor);
        void DeleteDoctor(int id);
    }
}
