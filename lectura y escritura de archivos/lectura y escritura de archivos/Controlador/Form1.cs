using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lectura_y_escritura_de_archivos
{
    public partial class Form1 : Form
    {
        ModeloSecuencial modelo = new ModeloSecuencial();
        VistaSecuencial vista = new VistaSecuencial();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnabrirarchivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)//solamente si el usuario dio ok en algun archivo mostrare la ruta en la caja de texto
            {
                txtarchivo.Text = openFileDialog1.FileName;
                List<Alumno> temp = new List<Alumno>();
                temp = modelo.leer(txtarchivo.Text);
                vista.imprime_lista(listView1, temp);

            }
        }

        private void btescribirarchivo_Click(object sender, EventArgs e)
        {
            Alumno AL = new Alumno();
            AL.Nombre = txtnombre.Text;
            AL.Direccion = txtdireccion.Text;
            AL.Edad = Convert.ToInt32(txtedad.Text);
            modelo.escribir(txtarchivo.Text, AL);
            //listView1.Items.Add(AL.Nombre,AL.Direccion,AL.Edad.ToString());
            listView1.Items.Add(AL.Nombre + AL.Direccion + AL.Edad.ToString());
        }
    }
}
