using LayerDataAccess.Entidades;
using LayerDataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerDataAccess.Implementaciones
{
    public class PlayListDBRepository : BaseRepository<PlayListDB, Int32>, IPlayListDBRepository
    {
        public PlayListDBRepository(IContext context) : base(context)
        {

        }

        public bool AddPlayListToUsuario(int idPlayList, int idUsuario)
        {
            context.PlayListsUsers.Add(new PlayListUserDB { PlayListId = idPlayList, UserId = idUsuario });
            context.SaveChanges();
            return true;
        }

        public List<PlayListDB> GetNoSeguidasByUsuario(int idUsuario)
        {
            var query = context.PlayLists.Join(context.PlayListsUsers,
                                                pl => pl.Id,
                                                plu => plu.PlayListId,
                                                (pl, plu) => new { PL = pl, PLU = plu })
                                          .Where(x => x.PLU.UserId != idUsuario)
                                          .Select(x=>x.PL);
            return query.ToList<PlayListDB>();            
        }

        public List<PlayListDB> GetSeguidasByUsuario(int idUsuario)
        {

            var query = context.PlayLists.Join(context.PlayListsUsers,
                                                pl => pl.Id,
                                                plu => plu.PlayListId,
                                                (pl, plu) => new { PL = pl, PLU = plu })
                                          .Where(x => x.PLU.UserId == idUsuario)
                                          .Select(x => x.PL);
            return query.ToList<PlayListDB>();
        }

        public bool RemovePlayListToUsuario(int idPlayList, int idUsuario)
        {
            context.PlayListsUsers.Remove(context.PlayListsUsers.First(plu => plu.PlayListId == idPlayList && plu.UserId == idUsuario));
            context.SaveChanges();
            return true;
        }
    }
}
