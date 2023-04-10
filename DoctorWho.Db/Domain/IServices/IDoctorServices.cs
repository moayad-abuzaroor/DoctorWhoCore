using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Persistence.Services.Communication;
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
        DoctorResponse InsertDoctor(Doctor doctor);
        DoctorResponse UpdateDoctor(int id, Doctor doctor);
        DoctorResponse DeleteDoctor(int id);
    }
}
