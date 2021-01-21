using LayerDataAccess.Configuraciones;
using LayerDataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerDataAccess
{
    public class Context : DbContext, IContext
    {
        public Context() : base("DB_Bitsion")
        { }

        public virtual DbSet<PlayListDB> PlayLists { get; set; }
        public virtual DbSet<UserDB> Users { get; set; }
        public virtual DbSet<PlayListUserDB> PlayListsUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Context>(null);
            modelBuilder.Configurations.Add(new PlayListDBEntityConfiguration());
            modelBuilder.Configurations.Add(new PlayListUserDBEntityConfiguration());
            modelBuilder.Configurations.Add(new UserDBEntityConfiguration());
        }
    }

    public interface IContext
    {
        DbSet<PlayListDB> PlayLists { get; set; }
        DbSet<UserDB> Users { get; set; }
        DbSet<PlayListUserDB> PlayListsUsers { get; set; }
    }
}
