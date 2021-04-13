using Microsoft.EntityFrameworkCore;
using Models;
using RainbowSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions options) : base(options)
        {
        }



        public DbSet<StudentModel> StudentModel { get; set; }
        public DbSet<ClassModel> ClassModel { get; set; }
        public DbSet<SubjectModel> SubjectModel { get; set; }

    }
}
