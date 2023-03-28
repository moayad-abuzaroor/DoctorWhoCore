using DoctorWho.Db.Functions;
using DoctorWho.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories {
    public class EnemyRepository {
        public void AddEnemy(string enemyName, string description) {
            var context = new DoctorWhoCoreDbContext();
            Enemy newEnemy = new Enemy() {
                EnemyName = enemyName,
                Description = description
            };
            context.Add(newEnemy);
            context.SaveChanges();
            /*var query = from e in context.tblEnemy select e;
            foreach (var e in query) {
                Console.WriteLine(e.EnemyName);
            }*/
        }

        public void UpdateEnemy(int id, string enemyName, string description) {
            var context = new DoctorWhoCoreDbContext();
            Enemy updateEnemy;
            updateEnemy = context.tblEnemy.Where(e => e.EnemyId == id).First();
            updateEnemy.EnemyName = enemyName;
            updateEnemy.Description = description;
            context.SaveChanges();
            /*var query = from e in context.tblEnemy select e;
            foreach (var e in query) {
                Console.WriteLine(e.EnemyName);
            }*/
        }

        public void DeleteEnemy(int id) {
            var context = new DoctorWhoCoreDbContext();
            Enemy deleteEnemy;
            deleteEnemy = context.tblEnemy.Where(e => e.EnemyId == id).First();
            context.Remove(deleteEnemy);
            context.SaveChanges();
            /*var query = from e in context.tblEnemy select e;
            foreach(var e in query) {
                Console.WriteLine(e.EnemyName);
            }*/
        }

        public List<fnEnemiesClass> enemiesFunctionClass(int episodeId) {
            var context = new DoctorWhoCoreDbContext();
            var query = from e in context.fnEnemies(episodeId) select e;
            foreach (var e in query) {
                Console.WriteLine($"Enemy Name: {e.EnemyName}");
            }
            return query.ToList();
        }

        public List<Enemy> GetEnemyById(int id) {
            var context = new DoctorWhoCoreDbContext();
            var query = from e in context.tblEnemy
                        where e.EnemyId == id
                        select e;
            return query.ToList();
        }

    }
}
