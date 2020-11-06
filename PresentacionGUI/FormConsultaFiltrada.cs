using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FormConsultaFiltrada : Form
    {
        DataTable table = new DataTable();
        PersonaService service = new PersonaService();
        public FormConsultaFiltrada()
        {
            InitializeComponent();
            table.Columns.Add("Cedula");
            table.Columns.Add("Nombre");
            table.Columns.Add("Edad");
            table.Columns.Add("Sexo");
            table.Columns.Add("Pulsacion");

            dataGridConsulta.DataSource = table;

        }

        private void BtnConsultarFiltro_Click(object sender, EventArgs e)
        {
           

            if (cmboSexo.Text.Equals("Todos"))
            {
                ConsultarTodos();
                lblConteo.Text = "----";
            }
            else
            {
                ConsultaConFiltroSexo();
                ContarSexo();
            }
          
            
        }
        private void ContarSexo()
        {
            int cantidad = 0;
            cantidad = service.ContarSexo(cmboSexo.Text);
            if (cantidad != 0)
            {
                lblConteo.Text = "" + cantidad;
            }else
            {
                lblConteo.Text = "0";
                MessageBox.Show("No existen registros : "  +cmboSexo.Text,"informacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void ConsultaNombre()
        {
            var respuesta = service.ConsultarNombre(txtNombre.Text);
            if (respuesta.PersonaEncontrada)
            {
                dataGridConsulta.DataSource = respuesta.Personas;

            }
            else
            {
                MessageBox.Show(respuesta.Message, "Informacion de Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void ConsultarTodos()
        {
            var respuesta = service.ConsultarTodos();
            if (respuesta.PersonaEncontrada)
            {
                dataGridConsulta.DataSource = respuesta.Personas;
            }
            else
            {
                MessageBox.Show(respuesta.Message, "Informacion de Consulta");
            }
        }



        private void ConsultaConFiltroSexo()
        {

            var response = service.ConsultarPorSexo(cmboSexo.Text);
            if (response.PersonaEncontrada)
            {

                dataGridConsulta.DataSource = response.Personas;

            }
            else
            {
                MessageBox.Show(response.Message, "Informacion Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConsultarNombre_Click(object sender, EventArgs e)
        {
            ConsultaNombre();
        }
    }
}
