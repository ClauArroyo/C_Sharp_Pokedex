using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PruebasBBDD
{
    
    public partial class Evolucion : Form
    {
        Conexion miConexion = new Conexion();
        public Evolucion(int id)
        {
            InitializeComponent();
            DataTable pokemonElegido = miConexion.getPokemonPorId(id);
            pokemonElegido = miConexion.getPokemonPorId(id);
            pictureBox1.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
            if (pokemonElegido.Rows[0]["posEvolucion"]!= DBNull.Value)
            {
                DataTable pokemonElegido2 = miConexion.getPokemonPorId(id + 1);
                pictureBox2.Image = convierteBlobAImagen((byte[])pokemonElegido2.Rows[0]["imagen"]);
                if (pokemonElegido.Rows[0]["posEvolucion"] != DBNull.Value)
                {
                    DataTable pokemonElegido3 = miConexion.getPokemonPorId(id + 2);
                    pictureBox3.Image = convierteBlobAImagen((byte[])pokemonElegido3.Rows[0]["imagen"]);
                }
            }
            
        }
        private Image convierteBlobAImagen(byte[] img)
        {
            return (Image.FromStream(new System.IO.MemoryStream(img)));
        }
    }
}
