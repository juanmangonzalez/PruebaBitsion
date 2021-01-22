using LayerModel;
using LayerModel.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitsionPrueba.ViewModels
{
    public class PlayListViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantidadCanciones { get; set; }
        public TimeSpan Duracion { get; set; }
        public List<PlayList> AllPlayLists { get; set; }
        public List<User> Users { get; set; }
        public int IdUsuarioSeleccionado { get; set; }
        public string NombreUsuario { get; set; }
        public List<PlayList> PlayListsSeguidas { get; set; }
        public List<PlayList> PlayListsNoSeguidas { get; set; }
        public string MensajeError { get; set; }
    }
}