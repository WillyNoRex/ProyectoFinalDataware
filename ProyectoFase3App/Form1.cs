using System;
using System.Data;
using System.Windows.Forms;
using AppFase3;

namespace ProyectoFase3App
{
    public partial class Form1 : Form
    {
        private readonly ConexionBD accesoDatos;

        public Form1()
        {
            InitializeComponent();
            accesoDatos = new ConexionBD();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarTodosLosRegistros();
        }

        private void btn_prueba_Click(object sender, EventArgs e)
        {
            try
            {
                accesoDatos.ProbarConexion();
                MessageBox.Show(
                    "La conexión a SQL Server fue exitosa.",
                    "Conexión correcta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MostrarError("No fue posible probar la conexión.", ex);
            }
        }


        private void CargarTodosLosRegistros()
        {
            try
            {
                DataTable registros = accesoDatos.ObtenerTodosLosRegistros();

                dgvDatos.AutoGenerateColumns = true;
                dgvDatos.DataSource = registros;
                FormatearTabla();


                if (registros.Rows.Count == 0)
                {
                    lblEstado.Text = "No hay registros disponibles en la base de datos.";
                }
                else
                {
                    lblEstado.Text = $"Registros cargados desde SQL Server: {registros.Rows.Count}";
                }

            }
            catch (Exception ex)
            {
                MostrarError("No fue posible cargar los registros.", ex);
            }
        }



        private void FormatearTabla()
        {
            // Encabezados claros en español
            CambiarEncabezado("cliente_id", "ID cliente");
            CambiarEncabezado("nombre", "Nombre");
            CambiarEncabezado("apellido", "Apellido");
            CambiarEncabezado("genero", "Género");
            CambiarEncabezado("edad", "Edad");
            CambiarEncabezado("departamento", "Departamento");
            CambiarEncabezado("municipio", "Municipio");
            CambiarEncabezado("correo", "Correo electrónico");
            CambiarEncabezado("fecha_registro", "Fecha de registro");
            CambiarEncabezado("tipo_cliente", "Tipo de cliente");
            CambiarEncabezado("total_compras_usd", "Total de compras (USD)");

            // Formato de fecha
            if (dgvDatos.Columns.Contains("fecha_registro"))
            {
                dgvDatos.Columns["fecha_registro"]!.DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            // Formato de números con dos decimales
            if (dgvDatos.Columns.Contains("total_compras_usd"))
            {
                dgvDatos.Columns["total_compras_usd"]!.DefaultCellStyle.Format = "N2";
            }
        }

        private void CambiarEncabezado(string nombreColumna, string encabezado)
        {
            if (dgvDatos.Columns.Contains(nombreColumna))
            {
                dgvDatos.Columns[nombreColumna]!.HeaderText = encabezado;
            }
        }



        private void MostrarError(string contexto, Exception ex)
        {
            MessageBox.Show(
                $"{contexto}\n\n{ex.Message}",
                "Error de acceso a datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            lblEstado.Text = "No se pudieron obtener datos de SQL Server.";
        }
    }
}
