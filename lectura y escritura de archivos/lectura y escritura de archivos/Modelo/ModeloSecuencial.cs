using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace lectura_y_escritura_de_archivos
{
    class ModeloSecuencial
    {
        private BinaryWriter escritor;
        private BinaryReader lector;

        public ModeloSecuencial()//el constructor no es ovligatorio
        {
            escritor = null;
            lector = null;

        }

        public void abrir_escritura(string archivo)
        {
            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);//sirve para escribir pero tenemos que tener el archivo cerrado o no tendra permiso de escritura
            escritor = new BinaryWriter(fs);
        }

        public void abrir_lectura(string archivo)
        {
            FileStream fs = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            lector = new BinaryReader(fs);

        }


        public void escribir(string archivo, Alumno a)//introduce los datos y despues cierra el escritor 
        {

            abrir_escritura(archivo);
            escritor.Write(a.Nombre);
            escritor.Write(a.Direccion);
            escritor.Write(a.Edad.ToString());
            escritor.Close();

        }

        public List<Alumno> leer(string archivo)
        {
            List<Alumno> alumnos = new List<Alumno>();
            if (escritor != null)
                escritor.Close();
            if (File.Exists(archivo))
            {
                abrir_lectura(archivo);
                try
                {
                    lector.Read();
                    while (true)
                    {

                        string nombre = lector.ReadString();
                        string direccion = lector.ReadString();
                        int edad = Convert.ToInt32(lector.ReadString());
                        alumnos.Add(new Alumno(nombre, direccion, edad));

                    }
                }

                catch (EndOfStreamException)
                {
                    //fin del archivo
                }
                finally
                {
                    lector.Close();
                }


            }
            else
                MessageBox.Show(String.Format("El archivo {0} no existe", archivo));
            return alumnos;
        }


    }//fin de la clas
  }//fin del namespacwe
