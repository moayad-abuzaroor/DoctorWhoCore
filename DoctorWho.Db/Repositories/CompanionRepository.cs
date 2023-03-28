using DoctorWho.Db.Functions;
using DoctorWho.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories {
    public class CompanionRepository {
        public void AddCompanion(string companionName, string whoPlayed) {
            var context = new DoctorWhoCoreDbContext();
            Companion newCompanion = new Companion() {
                CompanionName = companionName,
                WhoPlayed = whoPlayed
            };
            context.Add(newCompanion);
            context.SaveChanges();
            /*var query = from c in context.tblCompanion select c;
            foreach(var c in query) {
                Console.WriteLine(c.CompanionName);
            }*/
        }

        public void UpdateCompanion(int id, string companionName, string whoPlayed) {
            var context = new DoctorWhoCoreDbContext();
            Companion updateCompanion;
            updateCompanion = context.tblCompanion.Where(c => c.CompanionId == id).First();
            updateCompanion.CompanionName = companionName;
            updateCompanion.WhoPlayed = whoPlayed;
            context.SaveChanges();
            /*var query = from c in context.tblCompanion select c;
            foreach (var c in query) {
                Console.WriteLine(c.CompanionName);
            }*/
        }

        public void DeleteCompanion(int id) {
            var context = new DoctorWhoCoreDbContext();
            Companion deleteCompanion;
            deleteCompanion = context.tblCompanion.Where(c => c.CompanionId == id).First();
            context.Remove(deleteCompanion);
            context.SaveChanges();
            /*var query = from c in context.tblCompanion select c;
            foreach(var c in query) {
                Console.WriteLine(c.CompanionName);
            }*/
        }

        public List<Companion> GetCompanionById(int id) {
            var context = new DoctorWhoCoreDbContext();
            var query = from c in context.tblCompanion
                        where c.CompanionId == id
                        select c;
            return query.ToList();
        }

        public List<fnCompanionClass> companionFunctionClass(int episodeId) {
            int count = 1;
            var context = new DoctorWhoCoreDbContext();
            var query = from c in context.fnCompanions(episodeId) select c;
            foreach (var c in query) {
                Console.WriteLine($"Companion {count} Name: {c.CompanionName}");
                count++;
            }
            return query.ToList();
        }
    }
}
