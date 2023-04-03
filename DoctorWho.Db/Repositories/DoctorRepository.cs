using DoctorWho.Db.IRepositories;
using DoctorWho.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories {
    public class DoctorRepository : IDoctorRepository
    {
        public void AddDoctor(string doctorNumber, string doctorName,
            DateTime birthDate, DateTime firstEpisodeDate, DateTime lastEpisodeDate) {
            var context = new DoctorWhoCoreDbContext();
            Doctor newDoctor = new Doctor() {
                DoctorNumber = doctorNumber,
                DoctorName = doctorName,
                BirthDate = birthDate,
                FirstEpisodeDate = firstEpisodeDate,
                LastEpisodeDate = lastEpisodeDate
            };
            context.Add(newDoctor);
            context.SaveChanges();
        }

        public void UpdateDoctor(int id, string doctorNumber, string doctorName,
            DateTime birthDate, DateTime firstEpisodeDate, DateTime lastEpisodeDate) {
            var context = new DoctorWhoCoreDbContext();
            Doctor updateDoctor;
            updateDoctor = context.tblDoctor.Where(d => d.DoctorId == id).First();
            updateDoctor.DoctorNumber = doctorNumber;
            updateDoctor.DoctorName = doctorName;
            updateDoctor.BirthDate = birthDate;
            updateDoctor.FirstEpisodeDate = firstEpisodeDate;
            updateDoctor.LastEpisodeDate = lastEpisodeDate;

            context.SaveChanges();
        }

        public void DeleteDoctor(int id) {
            var context = new DoctorWhoCoreDbContext();
            Doctor deleteDoctor;
            deleteDoctor = context.tblDoctor.Where(d => d.DoctorId == id).First();
            context.Remove(deleteDoctor);
            context.SaveChanges();
        }

        public List<Doctor> GetAllDoctors() {
            var context = new DoctorWhoCoreDbContext();
            var query = from d in context.tblDoctor select d;
            return query.ToList();
        }
    }
}
