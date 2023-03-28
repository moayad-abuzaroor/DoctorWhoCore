﻿using DoctorWho.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories {
    public class AuthorRepository {
        public void AddAuthor(string authorName) {
            var context = new DoctorWhoCoreDbContext();
            Author newAuthor = new Author() {
                AuthorName = authorName
            };
            context.Add(newAuthor);
            context.SaveChanges();
        }

        public void UpdateAuthor(int id, string authorName) {
            var context = new DoctorWhoCoreDbContext();
            Author updateAuthor;
            updateAuthor = context.tblAuthor.Where(a => a.AuthorId == id).First();
            updateAuthor.AuthorName = authorName;
            context.SaveChanges();
        }

        public void DeleteAuthor(int id) {
            var context = new DoctorWhoCoreDbContext();
            Author deleteAuthor;
            deleteAuthor = context.tblAuthor.Where(a => a.AuthorId == id).First();
            context.Remove(deleteAuthor);
            context.SaveChanges();
        }
    }
}
