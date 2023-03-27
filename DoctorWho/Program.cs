using DoctorWho.Db;
using DoctorWho.Db.Functions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoctorWho
{
    public class Program {
        static void Main(string[] args) {
            var fnCompanions = companionFunctionClass();
        }

        private static List<fnCompanionClass> companionFunctionClass() {
            var context = new DoctorWhoCoreDbContext();
            var query = from c in context.fnCompanions(1) select c;
            foreach(var c in query) {
                Console.WriteLine(c.CompanionName);
            }
            return query.ToList();
        }
    }
}
