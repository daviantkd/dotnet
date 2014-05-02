using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToMany.Models.Mappings
{
    public class BoyfriendMap : EntityTypeConfiguration<Boyfriend>
    {
        public BoyfriendMap()
        {
            //Table mapping
            this.ToTable("Boyfriend");

            //Primary key
            this.HasKey(b => b.BoyfriendId);

            //Properties
            this.Property(b => b.BoyfriendId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(b => b.BoyfriendName)
                .IsRequired();

            //Relationship
            //FK_Boyfriend_Girl
            this.HasRequired(b => b.Girl)
                .WithMany(b => b.Boyfriends)
                .HasForeignKey(b => b.GirlId);
        }
    }
}
