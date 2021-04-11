using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Telerik_SampleProject.Database
{
    public class DatabaseConntext : DbContext
    {
        public DatabaseConntext()
        {

        }

        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);
        }
    }
}
