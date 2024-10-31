using System.Data;
using CapaDatos;
namespace CapaNegocio
{
    public class CN_Servicio
    {
        private  CD_Servicios objetoEscrito = new CD_Servicios();
        public DataTable MostrarServicio()
        {
            DataTable dt = new DataTable();
            dt = objetoEscrito.MostrarDatos();
            return dt;
        }
        public DataTable MostrarVenta()
        {
            DataTable dtAble = new DataTable();
            dtAble = objetoEscrito.MostrarDatosVentas();
            return dtAble;
        }

        public void IngresarServicio(string Tipo, string direccion, int m2, int precio)
        {
            objetoEscrito.InsertarServicio(Tipo, direccion, m2, precio);
        }
        public void IngresarServicioVenta(int id, int idProp, int precio, int iva, int descuento, int PrecioTotal)
        {
            objetoEscrito.VenderPropiedad(id, idProp, precio, iva, descuento, PrecioTotal);
        }

        public void EditarServicio(int id, string Tipo, string direccion, int m2, int precio)
        {
            objetoEscrito.ActualizarVehiculo(id, Tipo, direccion, m2, precio);
        }

        public void EliminarServicio(int id)
        {
            objetoEscrito.EliminarServicio(id);
        }


    }
}

//public void InsertarServicio(int id, string Tipo, string direccion, int m2, int precio)
//VenderPropiedad(int id, int idProp, int precio, double iva, int descuento, int PrecioTotal