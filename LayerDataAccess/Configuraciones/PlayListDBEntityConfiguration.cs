using LayerDataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerDataAccess.Configuraciones
{
    public class PlayListDBEntityConfiguration : EntityTypeConfiguration<PlayListDB>
    {
        public PlayListDBEntityConfiguration()
        {
            this.ToTable("PlayLists");
            this.HasKey(p => p.Id);

            this.Property(p => p.Nombre).HasColumnName("Nombre");
            this.Property(p => p.CantidadCanciones).HasColumnName("CantidadCanciones");
            this.Property(p => p.Duracion).HasColumnName("Duracion");
        }
    }
}
