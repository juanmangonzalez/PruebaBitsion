using LayerDataAccess;
using LayerDataAccess.Entidades;
using LayerDataAccess.Implementaciones;
using LayerDataAccess.Interfaces;
using LayerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerBus.Implementaciones
{
    public class PlayListBus : IPlayListBus
    {
        private readonly IContext context;
        private readonly IPlayListDBRepository playListRepository;
        private readonly IPlayListUserDBRepository playListUserRepository;

        public PlayListBus(IContext context)
        {
            this.context = context;
            this.playListRepository = new PlayListDBRepository(context);
            this.playListUserRepository = new PlayListUserDBRepository(context);
        }

        public List<PlayList> GetAll()
        {
            var listFromDB = playListRepository.GetAll().ToList();
            return MapDBToBus(listFromDB);
        }

        public List<PlayList> GetNoSeguidasByUsuario(int idUsuario)
        {
            var listFromDB = playListRepository.GetNoSeguidasByUsuario(idUsuario);
            return MapDBToBus(listFromDB);
        }

        public List<PlayList> GetSeguidasByUsuario(int idUsuario)
        {
            var listFromDB = playListRepository.GetSeguidasByUsuario(idUsuario);
            return MapDBToBus(listFromDB);
        }

        private List<PlayList> MapDBToBus(List<PlayListDB> listFromDB)
        {
            List<PlayList> listBus = new List<PlayList>();
            foreach (var pl in listFromDB)
            {
                listBus.Add(new PlayList
                {
                    Id = pl.Id,
                    Nombre = pl.Nombre,
                    CantidadCanciones = pl.CantidadCanciones,
                    Duracion = pl.Duracion,
                    Seguidores = playListUserRepository.GetByPlayListId(pl.Id).Count()
                });
            }

            return listBus;
        }
    }
}
