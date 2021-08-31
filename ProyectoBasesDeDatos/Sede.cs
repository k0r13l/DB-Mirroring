using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDeDatos
{
    class Sede
    {
        public Sede(int IdSede, String NombreSede)
        {
            this.IdSede = IdSede;
            this.NombreSede = NombreSede;
        }

        public int IdSede { get; set; }
        public String NombreSede { get; set; }
    }
}
