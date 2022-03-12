using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido Facundo");
        }

        // Evento click para saludar ingresando nombre.
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola Facu");
            string nombre = textNombre.Text;
            label1.Text = "Hola " + nombre;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void datos_Click(object sender, EventArgs e)
        {

        }
    }
}
