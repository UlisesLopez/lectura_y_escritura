using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lectura_y_escritura_de_archivos
{
    class VistaSecuencial
    {

        public void imprime_lista(ListView lv, List<Alumno> alumnos)
        {

            lv.Items.Clear();
            foreach (Alumno alumno in alumnos)
            {
                ListViewItem item = lv.Items.Add(alumno.Nombre);
                item.SubItems.Add(alumno.Direccion);
                item.SubItems.Add(alumno.Edad.ToString());  

            }

        }


    }//fin de la clase 
}//fin del namespace 
