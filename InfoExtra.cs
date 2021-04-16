using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PruebasBBDD
{
    public partial class InfoExtra : Form
    {
        Conexion miConexion = new Conexion();

        public InfoExtra(int id)
        {
            InitializeComponent();
            DataTable pokemonElegido = miConexion.getPokemonPorId(id);
            pokemonElegido = miConexion.getPokemonPorId(id);
            label1.Text = pokemonElegido.Rows[0]["tipo1"].ToString();
            label2.Text = pokemonElegido.Rows[0]["tipo2"].ToString();
            label3.Text = pokemonElegido.Rows[0]["habilidad"].ToString();
            label4.Text = pokemonElegido.Rows[0]["movimiento1"].ToString();
            label5.Text = pokemonElegido.Rows[0]["movimiento2"].ToString();
            label6.Text = pokemonElegido.Rows[0]["movimiento3"].ToString();
            label7.Text = pokemonElegido.Rows[0]["movimiento4"].ToString();
            label8.Text = pokemonElegido.Rows[0]["descripcion"].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
