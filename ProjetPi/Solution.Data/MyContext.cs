using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Data
{
    public class MyContext : DbContext
    {
        public MyContext():base("name=machaine")
        {

        }
        // dbset
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add();
            //modelBuilder.Conventions.Add();
        }
    }
}
