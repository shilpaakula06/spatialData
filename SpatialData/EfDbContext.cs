using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpatialData
{
    public class EfDbContext : System.Data.Entity.DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //TODO Extract connection string to a secret
        //    optionsBuilder.UseSqlServer(@"Server=.\;Database=EFCodeFirstDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        //}
        public System.Data.Entity.DbSet<Item> Items { get; set; }
    }
}
