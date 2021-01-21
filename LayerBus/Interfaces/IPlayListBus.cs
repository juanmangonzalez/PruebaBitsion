using LayerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerBus
{
    public interface IPlayListBus
    {
        List<PlayList> GetAll();
        List<PlayList> GetSeguidasByUsuario(int idUsuario);
        List<PlayList> GetNoSeguidasByUsuario(int idUsuario);
    }
}
