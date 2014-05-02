using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OneToMany.Models;
using OneToMany.Models.Mappings;

namespace OneToMany
{
    public class OneToManyContext : DbContext
    {
        /*
        static OneToManyContext()
        {
            Database.SetInitializer<OneToManyContext>(null);
        }

        public static OneToManyContext()
            : base("Name = OneToManyContext")
        {
            Database.SetInitializer<OneToManyContext>(null);
        }
        */

        public OneToManyContext()
            : base("Name = OneToManyContext")
        {
        }

        public DbSet<Girl> Girls { get; set; }
        public DbSet<Boyfriend> Boyfriends { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GirlMap());
            modelBuilder.Configurations.Add(new BoyfriendMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
