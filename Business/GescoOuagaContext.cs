using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Scaffolding.Models;

namespace Business
{
    public partial class GescoOuagaContext : DbContext
    {
        public DbSet<Admission> Admissions { get; set; }

        public DbSet<Cycle> Cycles { get; set; }

        // DbSet for SchoolInfo
        public DbSet<SchoolInfo> SchoolInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-LBN9HF5\\SQLEXPRESS;Database=gescoOuaga;Trusted_Connection=True;Encrypt=No;");
            }
        }
    }
}
