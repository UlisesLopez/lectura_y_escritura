using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lectura_y_escritura_de_archivos
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }


        public Alumno(string nombre, string direccion, int edad)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Edad = edad;

        }

        public Alumno()
        {
            Nombre = null;
            Direccion = null;
            Edad = 0;

        }


    }//fin de la clase
}//fin del namespace
