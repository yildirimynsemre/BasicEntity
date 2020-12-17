using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ProEntity.Context
{
    public class DBContext : DbContext
    {
        public DBContext() : base("BlogContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // İlişkileri kuruyoruz one-to-many olarak.
        }
    }
}
