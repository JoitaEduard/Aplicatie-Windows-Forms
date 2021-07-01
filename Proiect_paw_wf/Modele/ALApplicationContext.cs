using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_paw_wf.Modele
{
    public class ALApplicationContext: DbContext
    {
        public DbSet<Companie> Companii { get; set; }
        public DbSet<Ruta> Rute { get; set; }

        public ALApplicationContext()
        {
            try 
            {
                Database.Migrate();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=AirLine.db");
        }

    }


}
