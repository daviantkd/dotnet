using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToMany.Models.Mappings
{
    public class GirlMap : EntityTypeConfiguration<Girl>
    {
        public GirlMap()
        {
            //Table mapping
            this.ToTable("Girl");

            //Primary key
            this.HasKey(g => g.GirlId);

            //Properties
            this.Property(g => g.GirlId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(g => g.GirlName)
                .IsRequired();
        }
    }
}
