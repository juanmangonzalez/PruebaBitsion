using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerDataAccess.Entidades
{
    public class PlayListDB
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CantidadCanciones { get; set; }
        public TimeSpan Duracion { get; set; }

    }
}
