using LayerDataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerDataAccess.Interfaces
{
    public interface IPlayListUserDBRepository 
    {
        List<PlayListUserDB> GetByPlayListId(int idPlayList);
    }
}
