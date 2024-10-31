using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private MySqlConnection Conexion = new MySqlConnection("Server=127.0.0.1;Port=33067;Database=escrito;uid=root;pwd=matimartu");

        public MySqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion; // Devolver la conexión, esté abierta o cerrada.
        }

        public MySqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion; // Devolver la conexión, esté abierta o cerrada.
        }
    }
}
