using DoctorWho.Db.Domain.IRepositories;
using DoctorWho.Db.Domain.IServices;
using DoctorWho.Db.Domain.Models;
using DoctorWho.Db.Persistence.Repositories;
using DoctorWho.Db.Persistence.Services.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Persistence.Services
{
    public class DoctorServices : IDoctorServices
    {
        IGenericRepository<Doctor> repoDoctor = new GenericRepository<Doctor>();

        public DoctorResponse DeleteDoctor(int id)
        {
            var existingDoctor = repoDoctor.GetById(id);
            if (existingDoctor == null)
                return new DoctorResponse("Doctor not found");

            try
            {
                repoDoctor.Delete(id);
                repoDoctor.Save();

                return new DoctorResponse(existingDoctor);
            }
            catch (Exception ex)
            {
                return new DoctorResponse($"An error occurred when deleting doctor: {ex.Message}");
            }
        }

        public IEnumerable<Doctor> GetAllDoctors()
        {
            return repoDoctor.GetAll();
        }

        public Doctor GetDoctorById(int id)
        {
            return repoDoctor.GetById(id);
        }

        public DoctorResponse InsertDoctor(Doctor doctor)
        {
            try
            {
                repoDoctor.Insert(doctor);
                repoDoctor.Save();

                return new DoctorResponse(doctor);
            }
            catch(Exception ex)
            {
                return new DoctorResponse($"An error occurred when adding doctor: {ex.Message}");
            }
        }

        public DoctorResponse UpdateDoctor(int id, Doctor doctor)
        {
            var existingDoctor = repoDoctor.GetById(id);
            if (existingDoctor == null)
                return new DoctorResponse("Doctor not found");

            existingDoctor.DoctorName = doctor.DoctorName;
            existingDoctor.DoctorNumber = doctor.DoctorNumber;
            existingDoctor.BirthDate = doctor.BirthDate;
            existingDoctor.FirstEpisodeDate = doctor.FirstEpisodeDate;
            existingDoctor.LastEpisodeDate = doctor.LastEpisodeDate;

            try
            {
                repoDoctor.Update(existingDoctor);
                repoDoctor.Save();

                return new DoctorResponse(doctor);
            }
            catch (Exception ex)
            {
                return new DoctorResponse($"An error occurred when updating doctor: {ex.Message}");
            }

        }
    }
}
