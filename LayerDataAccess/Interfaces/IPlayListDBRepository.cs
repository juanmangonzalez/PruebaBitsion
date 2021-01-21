using LayerDataAccess.Entidades;
using LayerDataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerDataAccess.Interfaces
{
    public interface IPlayListDBRepository : IRepository<PlayListDB, Int32>
    {
        List<PlayListDB> GetSeguidasByUsuario(int idUsuario);
        List<PlayListDB> GetNoSeguidasByUsuario(int idUsuario);
        bool AddPlayListToUsuario(int idPlayList, int idUsuario);
        bool RemovePlayListToUsuario(int idPlayList, int idUsuario);
    }
}
