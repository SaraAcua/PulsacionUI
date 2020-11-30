using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class Probar_conexion : Form
    {

        private SqlConnection conexion = null;
        public Probar_conexion()
        {
            InitializeComponent();


            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = pulsaciones; Integrated Security = True";
            conexion = new SqlConnection(connectionString);
        }

        private void Probar_conexion_Load(object sender, EventArgs e)
        {

        }
        private void btnMostarConexion_Click(object sender, EventArgs e)
        {
                try
                {
                    // Probar a abrir la conexión
                    conexion.Open();
                    txtVersion.Text = "Versión del servidor: " + conexion.ServerVersion;
                    txtEstadoConexion.Text = "La conexion está: ";
                    txtEstadoConexion.Text += conexion.State.ToString();
                    txtEstadoConexion.Text += "\nSe accede a la base de datos";
                }
                catch (Exception ex)
                {
                    // Manipular la excepción
                    txtEstadoConexion.Text = "Error al acceder a la base de datos. "
                    + ex.Message;
                }
                finally
                {
                    // Asegurarse de que la conexión queda cerrada.
                    // Aunque la conexión estuviera cerrada,
                    // llamar a Close() no produce un error.
                    conexion.Close();
                    txtEstadoConexion.Text += "\nAhora la conexion está: " +
                    conexion.State.ToString();
                }
            }
        }
    }

    
