using DoctorWho.Db.IRepositories;
using DoctorWho.Db.IServices;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Services
{
    public class DoctorServices : IDoctorServices
    {
        IGenericRepository<Doctor> repoDoctor = new GenericRepository<Doctor>();

        public void DeleteDoctor(int id)
        {
            repoDoctor.Delete(id);
        }

        public IEnumerable<Doctor> GetAllDoctors()
        {
            return repoDoctor.GetAll();
        }

        public Doctor GetDoctorById(int id)
        {
            return repoDoctor.GetById(id);
        }

        public void InsertDoctor(Doctor doctor)
        {
            repoDoctor.Insert(doctor);
        }

        public void UpdateDoctor(Doctor doctor)
        {
            repoDoctor.Update(doctor);
        }
    }
}
