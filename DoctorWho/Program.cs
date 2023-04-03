using DoctorWho.Db;
using DoctorWho.Db.Functions;
using DoctorWho.Db.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Infrastructure;
using DoctorWho.Db.Views;
using static Azure.Core.HttpHeader;
using DoctorWho.Db.Repositories;
using DoctorWho.Db.IRepositories;
using DoctorWho.Db.IServices;
using DoctorWho.Db.Services;

namespace DoctorWho
{
    public class Program {
        static void Main(string[] args)
        {
            AuthorRepository author = new AuthorRepository();
            CompanionRepository companion = new CompanionRepository();
            DoctorRepository doctor = new DoctorRepository();
            EnemyRepository enemy = new EnemyRepository();
            EpisodeRepository episode = new EpisodeRepository();
            Console.WriteLine("----------------");
        }
                
    }
}
