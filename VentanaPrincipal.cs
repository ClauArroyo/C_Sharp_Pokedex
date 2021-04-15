using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PruebasBBDD
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PokedexBasica ventana = new PokedexBasica();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
        }
    }
}
