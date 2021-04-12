using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Telerik_SampleProject.Model;

namespace Telerik_SampleProject.Database
{
    public class DatabaseConntext : DbContext
    {
        public DbSet<RegistrationModel> Registraion { get; set; }
        public DatabaseConntext(DbContextOptions<DatabaseConntext> Options):base(Options)
        {

        }

        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);
        }
    }
}
