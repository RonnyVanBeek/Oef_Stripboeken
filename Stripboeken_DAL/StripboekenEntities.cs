using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;

namespace Stripboeken_DAL
{
    internal class StripboekenEntities : DbContext
    {
        public StripboekenEntities() : base("StripboekenDB")
        {
        }

        public DbSet<Genres> Genres { get; set; }
        public DbSet<Reekstypes> Reekstypes { get; set; }
        public DbSet<Reeksen> Reeksen { get; set; }
        public DbSet<ReeksenGenre> ReeksenGenres { get; set; }
        public DbSet<Albums> Albums { get; set; }
    }
}