using LayerDataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerDataAccess.Configuraciones
{
    public class PlayListUserDBEntityConfiguration : EntityTypeConfiguration<PlayListUserDB>
    {
        public PlayListUserDBEntityConfiguration()
        {
            this.ToTable("PlayList_X_User");
            this.HasKey(d => new { d.PlayListId, d.UserId});
        }
    }
}
