using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Servicios
    {
        private CD_Conexion conexion = new CD_Conexion();
        MySqlCommand cmd = new MySqlCommand();
        
        // Método para mostrar los datos de la tabla Servicio
        public DataTable MostrarDatos()
        {
            try
            {
                MySqlDataReader Leer;
                DataTable tablaProgramacion = new DataTable();
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "SELECT * FROM Propiedades";
                Leer = cmd.ExecuteReader();
                tablaProgramacion.Load(Leer);
                return tablaProgramacion;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al mostrar los datos: " + ex.Message);
                return null;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public DataTable MostrarDatosVentas()
        {
            try
            {
                MySqlDataReader Leer;
                DataTable tablaProgramacion = new DataTable();
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "SELECT * FROM Venta";
                Leer = cmd.ExecuteReader();
                tablaProgramacion.Load(Leer);
                return tablaProgramacion;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al mostrar los datos: " + ex.Message);
                return null;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void InsertarServicio(string Tipo, string direccion, int m2, int precio)
        {
            try
            {
                //Hola profe esto es para insertar datos
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "INSERT INTO Propiedades (tipo, direccion, m2, precio) VALUES ('" + Tipo + "', '" + direccion + "' ," + m2 + "," + precio;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al insertar el servicio: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        public void VenderPropiedad(int id, int idProp, int precio, int iva, int descuento, int PrecioTotal)
        {
            try
            {
                //Hola profe esto es para insertar datos
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "INSERT INTO Venta (id_propiedad, precio, descuento, iva, precio_total) VALUES (@ID, @IDPROP, @precio, @IVA, @PrecioTotal);";
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@IDPROP", idProp);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@IVA", iva);
                cmd.Parameters.AddWithValue("@PrecioTotal", PrecioTotal);
                cmd.CommandType= CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

            }

            catch (MySqlException ex)
            {
                Console.WriteLine("Error al insertar el servicio: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        public void ActualizarVehiculo(int id, string Tipo, string direccion, int m2, int precio)
        {
            try
            {   
                //Hola profe esto es para editar datos
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "UPDATE Propiedades SET tipo = @TipoPropiedad, direccion = @Direccion, m2 = @M2, precio = @Precio WHERE id = @ID ";
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@TipoPropiedad", Tipo);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@M2", m2);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.CommandType= CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();


            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al editar el servicio: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        public void EliminarServicio(int ID)
        {
            try
            {
                // Hola profe esto es para eliminar datos 
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "DELETE FROM Propiedades WHERE id = @ID";
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al eliminar el servicio: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
