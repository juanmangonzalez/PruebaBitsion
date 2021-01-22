using LayerDataAccess.Entidades;
using LayerDataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerDataAccess.Implementaciones
{
    public class PlayListUserDBRepository : IPlayListUserDBRepository
    {
        protected readonly Context context;
        public PlayListUserDBRepository(IContext context) 
        {
            this.context = (Context)context;
        }
        public List<PlayListUserDB> GetByPlayListId(int idPlayList)
        {
            return context.PlayListsUsers.Where(plu => plu.PlayListId == idPlayList).ToList();
        }
    }
}
