using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PruebasBBDD
{
    public partial class PokedexBasica : Form
    {
        Conexion miConexion = new Conexion();
        int idActual = 1;
        public PokedexBasica()
        {
            InitializeComponent();
            asignaPokemon();
        }

        //boton de la derecha
        private void button2_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual > 151)
            {
                idActual = 1;
            }
            miConexion.getPokemonPorId(idActual);
            asignaPokemon();
        }

        //botón de la izquierda
        private void button1_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual < 0)
            {
                idActual = 151;
            }
            asignaPokemon();
        }

        private void asignaPokemon()
        {
            DataTable pokemonElegido = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = pokemonElegido.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void boton_altura(object sender, EventArgs e)
        {
            DataTable pokemonElegido = miConexion.getPokemonPorId(idActual);
            datosPokemon.Text = pokemonElegido.Rows[0]["altura"].ToString();
        }

        private void boton_peso(object sender, EventArgs e)
        {
            DataTable pokemonElegido = miConexion.getPokemonPorId(idActual);
            datosPokemon.Text = pokemonElegido.Rows[0]["peso"].ToString();
        }

        private void boton_especie(object sender, EventArgs e)
        {
            DataTable pokemonElegido = miConexion.getPokemonPorId(idActual);
            datosPokemon.Text = pokemonElegido.Rows[0]["especie"].ToString();
        }
        private void boton_habitat(object sender, EventArgs e)
        {
            DataTable pokemonElegido = miConexion.getPokemonPorId(idActual);
            datosPokemon.Text = pokemonElegido.Rows[0]["habitat"].ToString();
        }

        private void boton_evolucion(object sender, EventArgs e)
        {
            Evolucion ventana = new Evolucion();
            ventana.Show();
        }

        private void info_extra(object sender, EventArgs e)
        {
            InfoExtra ventana = new InfoExtra();
            ventana.Show();
        }

    }
}
