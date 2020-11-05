using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace PresentacionGUI
{
    public partial class FrmEliminar : Form
    {
        DataTable table = new DataTable();
        Persona persona = new Persona();
        PersonaService service = new PersonaService();
        public FrmEliminar()
        {
            InitializeComponent();

            table.Columns.Add("Cedula");
            table.Columns.Add("Nombre");
            table.Columns.Add("Edad");
            table.Columns.Add("Sexo");
            table.Columns.Add("Pulsacion");

            dataGEliminar.DataSource = table;
            dataGEliminar.DataSource = service.ConsultarTodos().Personas;
            dataGEliminar.Refresh();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona.Identificacion = TxtIdEliminar.Text;

            try
            {
                if (TxtIdEliminar.Text.Trim() != "")
                {

                    string mensaje = service.Eliminar(TxtIdEliminar.Text);
                    dataGEliminar.DataSource = service.ConsultarTodos().Personas;
                    dataGEliminar.Refresh();


                    MessageBox.Show(mensaje,"Informacion", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Digite una identificacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        private void TxtIdEliminar_DoubleClick(object sender, EventArgs e)
        {
            persona.Identificacion = TxtIdEliminar.Text;
            PersonaResponse personaResponse = service.BuscarPorIdentificacion(TxtIdEliminar.Text);
          
            if (personaResponse.PersonaEncontrada)
            {

                table.Rows.Add(personaResponse.Persona.Identificacion,
                          personaResponse.Persona.Nombre, personaResponse.Persona.Edad, personaResponse.Persona.Sexo,
                          personaResponse.Persona.Pulsacion);
                dataGEliminar.DataSource = table;

            }
            else
            {
                MessageBox.Show("No existe el usuario registrado");
            }
        }

        private void dataGvEliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGEliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmEliminar_Load(object sender, EventArgs e)
        {

        }
    }
}
