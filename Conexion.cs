using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient; //la librería de MySql
using System.Data; //la librería del DataTable

namespace PruebasBBDD
{
    class Conexion
    {
        public MySqlConnection conexion; //variable que se encarga de conectarnos al servidor MySql
        
        public Conexion() //este es el constructor de la clase
        {
            conexion = new MySqlConnection("Server=127.0.0.1; Database=listapokemons; Uid=root; Pwd=; Port=3306");
        }

        public DataTable getPokemons()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado de la consulta (Query)
                DataTable pokemons = new DataTable(); //formato que espera el datagridview
                pokemons.Load(resultado); //Convierte MySqlDataReader en DataTable
                conexion.Close();
                return pokemons;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }

    }
}
