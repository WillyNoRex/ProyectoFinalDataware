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
                lblEstado.Text = $"Registros cargados desde SQL Server: {registros.Rows.Count}";
            }
            catch (Exception ex)
            {
                MostrarError("No fue posible cargar los registros.", ex);
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
