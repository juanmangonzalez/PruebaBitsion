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

        public List<PlayListDB> GetNoSeguidasByUsuario(int idUsuario)
        {
            var result = new List<PlayListDB>();
            var listSeguidas = GetSeguidasByUsuario(idUsuario);
            foreach (var pl in context.PlayLists)
            {
                if (listSeguidas.FirstOrDefault(x => x.Id == pl.Id) == null)
                    result.Add(pl);
            }
            return result;
        }

        public List<PlayListDB> GetSeguidasByUsuario(int idUsuario)
        {

            var query = context.PlayLists.Join(context.PlayListsUsers.Where(x => x.UserId == idUsuario),
                                                pl => pl.Id,
                                                plu => plu.PlayListId,
                                                (pl, plu) => new { PL = pl, PLU = plu })
                                          .Where(x => x.PLU.PlayListId == x.PL.Id)
                                          .Select(x => x.PL);
            return query.ToList<PlayListDB>();
        }

    }
}
