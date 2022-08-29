using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ejercicios_parejas
{
    internal class Conexion
    {
        public static MySqlConnection Conectar()
        {
            string cadena = "server=127.0.0.1; uid=root; database=EjercicioP;";
            MySqlConnection conex = new MySqlConnection(cadena);
            conex.Open();
            return conex;
        }
    }
}
