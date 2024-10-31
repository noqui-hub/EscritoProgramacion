using System;
using iTextSharp.text;
using iTextSharp;
using iTextSharp.text.pdf;

using System.Reflection;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Reflection.Metadata;
using System.Windows.Forms;
using CapaNegocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace FormEscrito
{
    public partial class CP_FormEscrito : Form
    {
        private bool editar = false;
        CN_Servicio objetoCN = new CN_Servicio();

        public CP_FormEscrito()
        {

            InitializeComponent();
            MostraServicio();
            MostraServicioVenta();
        }



        private void MostraServicio()
        {
            try
            {
                DataTable dataTable = objetoCN.MostrarServicio();
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo cargar los datos. Error: {ex.Message}");
            }
        }
        private void MostraServicioVenta()
        {
            try
            {
                DataTable dataTable = objetoCN.MostrarVenta();
                dgvVenta.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo cargar los datos. Error: {ex.Message}");
            }
        }
        private void CP_FormEscrito_Load(object sender, EventArgs e)
        {
            MostraServicio();
            MostraServicioVenta();
        }
        private void LimpiarBox()
        {

            ModeloBox.Text = "";
            MarcaBox.Text = "";
            ServicioBox.Text = "";
            AnioBox.Text = "";
        }
        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            if (

    string.IsNullOrWhiteSpace(ModeloBox.Text) ||
    string.IsNullOrWhiteSpace(MarcaBox.Text) ||
    string.IsNullOrWhiteSpace(AnioBox.Text) ||
    string.IsNullOrWhiteSpace(ServicioBox.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {

                if (!editar)
                {
                    int metrosCua = Convert.ToInt32(AnioBox.Text);
                    int precio = Convert.ToInt32(MarcaBox.Text);
                    int id = 0;
                    objetoCN.IngresarServicio(ServicioBox.Text, ModeloBox.Text, metrosCua, precio);
                    MessageBox.Show("Se ingresó correctamente.");
                    //int id, string Tipo, string direccion, int m2, int precio
                }
                else
                {
                    DataGridViewRow row = dataGridView1.CurrentRow;
                    string id = row.Cells["id"].Value?.ToString();
                    int idA = Convert.ToInt32(id);
                    objetoCN.EditarServicio(idA, ServicioBox.Text, ModeloBox.Text, Convert.ToInt32(MarcaBox.Text), Convert.ToInt32(this.AnioBox.Text));
                    MessageBox.Show("Se editó correctamente.");
                    editar = false;

                }
                MostraServicio();
                LimpiarBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo procesar los datos. Error: {ex.Message}");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                if (row != null)
                {
                    string id = row.Cells["id"].Value?.ToString();
                    int idA = Convert.ToInt32(id);
                    if (idA == null)
                    {
                        objetoCN.EliminarServicio(idA);
                        MessageBox.Show("Fue eliminado de forma correcta.");

                        LimpiarBox();
                        MostraServicio();

                    }
                    else
                    {
                        MessageBox.Show("El ID está vacío.");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                if (row != null)
                {
                    editar = true;
                    ServicioBox.Text = row.Cells["tipo"].Value?.ToString() ?? "";
                    ModeloBox.Text = row.Cells["direccion"].Value?.ToString() ?? "";
                    MarcaBox.Text = row.Cells["m2"].Value?.ToString() ?? "";
                    AnioBox.Text = row.Cells["precio"].Value?.ToString() ?? "";
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la fila seleccionada.");
                }
            }
            else
            {
                MessageBox.Show("Si desea editar debe seleccionar la fila deseada.");
            }
        }

        private void ServicioBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VenderBtn_Click(object sender, EventArgs e)
        {
            string idString, precioString, tipo;
            int id, precio = 0, descuento = 0, idInutil = 0;
            double iva = 0.22, precioIva = 0, precioTotal = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                if (row != null)
                {
                    editar = true;
                    idString = row.Cells["id"].Value?.ToString() ?? "";
                    tipo = row.Cells["tipo"].Value?.ToString() ?? "";
                    precioString = row.Cells["precio"].Value?.ToString() ?? "";
                    precio = Convert.ToInt32(precioString);
                    id = Convert.ToInt32(idString);
                    if (tipo == "Terreno")
                    {
                        descuento = 15;
                        precioIva = precio * iva;
                        precioIva = precio + precioIva;
                        int pIva = Convert.ToInt32(Math.Round(precioIva));
                        precioTotal = precioIva / descuento;
                        int pTotal = Convert.ToInt32(Math.Round(precioTotal));
                        objetoCN.IngresarServicioVenta(idInutil, id, precio, pIva, descuento, pTotal);
                        //id, idProp, precio, iva, descuento, PrecioTotal
                        MostraServicioVenta();
                    }
                    else
                    {
                        precioIva = precio * iva;
                        precioIva = precio + precioIva;
                        int pIva = Convert.ToInt32(Math.Round(precioIva));
                        precioTotal = precioIva;
                        int pTotal = Convert.ToInt32(Math.Round(precioTotal));
                        objetoCN.IngresarServicioVenta(idInutil, id, precio, pIva, descuento, pTotal);
                        MostraServicioVenta();
                        GenerarFacturaPDF(descuento, pTotal, pIva, tipo);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la fila seleccionada.");
                }
            }
            else
            {
                MessageBox.Show("Si desea editar debe seleccionar la fila deseada.");
            }
        }
        private void GenerarFacturaPDF(int descuento, int precioTotal, int PrecioIva, string Tipo)
        {
            string rutaArchivo = @"C:\Facturas\FacturaServicio.pdf";

            // Crear el documento PDF
            iTextSharp.text.Document documento = new iTextSharp.text.Document(PageSize.A4, 25, 25, 30, 30);

            try
            {
                // Comprobar si la carpeta existe y crearla si no
                Directory.CreateDirectory(Path.GetDirectoryName(rutaArchivo));

                // Crear el archivo PDF y escritor
                PdfWriter escritor = PdfWriter.GetInstance(documento, new FileStream(rutaArchivo, FileMode.Create));
                documento.Open();

                Assembly assembly = Assembly.GetExecutingAssembly();
                PdfPTable table = new PdfPTable(4); // 4 columnas
                table.WidthPercentage = 100; // Ancho de la tabla al 100%

                // Encabezados de la tabla
                table.AddCell("Tipo");
                table.AddCell("Descuento");
                table.AddCell("PrecioIva");
                table.AddCell("Total");

                // Agregar los detalles del servicio
                table.AddCell(Tipo);
                table.AddCell(descuento.ToString());
                table.AddCell(PrecioIva.ToString());
                table.AddCell(precioTotal.ToString());

                // Agregar la tabla al documento
                documento.Add(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}");
            }
            finally
            {
                documento.Close();
            }

        }
    }
    }
