
using EFCodeFirst_SoftDel_List.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_HardDel_List.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Vegtables> Vegtables { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Vegtables;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }


    }
}
