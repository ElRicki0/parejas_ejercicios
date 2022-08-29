using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ejercicios_parejas
{
    class Empleado
    {
        public int idEmpleado;
        public string nombreEmpleado;
        public string direccionEmpleado;
        public string teléfonoempleado;
        public float salarioEmpleado;
        public string paisEmpleado;

        public bool Agregar()
        {

            MySqlConnection conex = Conexion.Conectar();
            try
            {
                string comando = "insert into Directorio"
            }

        }
    }
}
