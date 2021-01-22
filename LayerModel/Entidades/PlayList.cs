using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerModel
{
    public class PlayList
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantidadCanciones { get; set; }
        public TimeSpan Duracion { get; set; }
        public int Seguidores{ get; set; }
    }
}
