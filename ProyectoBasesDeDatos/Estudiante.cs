using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasesDeDatos
{
    class Estudiante
    {
        /* Se usa para el dataDridBox*/
        public Estudiante(int Cedula, String Nombre, String Apellidos, int Edad, int IdSede, String NombreSede)
        {
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Edad = Edad;
            this.IdSede = IdSede;
            this.NombreSede = NombreSede;
        }

        /* Se usa para insertar o actualizar */
        public Estudiante(int Cedula, String Nombre, String Apellidos, int Edad, int IdSede)
        {
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Edad = Edad;
            this.IdSede = IdSede;
            this.NombreSede = "";
        }

        public int Cedula { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public int Edad { get; set; }
        public int IdSede { get; set; }
        public String NombreSede { get; set; }
    }
}
