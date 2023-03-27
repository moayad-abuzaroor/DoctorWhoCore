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
            Console.WriteLine("----------------");
            var fnEnemies = enemiesFunctionClass();
        }

        private static List<fnCompanionClass> companionFunctionClass() {
            int count = 1;
            var context = new DoctorWhoCoreDbContext();
            var query = from c in context.fnCompanions(1) select c;
            foreach(var c in query) {
                Console.WriteLine($"Companion {count} Name: {c.CompanionName}");
                count++;
            }
            return query.ToList();
        }
        private static List<fnEnemiesClass> enemiesFunctionClass() {
            var context = new DoctorWhoCoreDbContext();
            var query = from e in context.fnEnemies(1) select e;
            foreach (var e in query) {
                Console.WriteLine($"Enemy Name: {e.EnemyName}");
            }
            return query.ToList();
        }
    }
}
