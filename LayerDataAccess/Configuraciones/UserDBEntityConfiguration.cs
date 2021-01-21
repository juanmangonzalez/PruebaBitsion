using LayerDataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerDataAccess.Configuraciones
{
    public class UserDBEntityConfiguration : EntityTypeConfiguration<UserDB>
    {
        public UserDBEntityConfiguration()
        {
            this.ToTable("Users");
            this.HasKey(d => d.Id);

            this.Property(p => p.Nombre).HasColumnName("Nombre");
        }
    }
}