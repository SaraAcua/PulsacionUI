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
    public partial class Consulta : Form
    {
       
        DataTable table = new DataTable();
        Persona persona = new Persona();
        PersonaService service = new PersonaService();
        public Consulta()
        {
            
            InitializeComponent();
            table.Columns.Add("Cedula");
            table.Columns.Add("Nombre");
            table.Columns.Add("Edad");
            table.Columns.Add("Sexo");
            table.Columns.Add("Pulsacion");

            dataGridConsulta.DataSource = table;

          

        }
        
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            persona.Identificacion = txtId.Text;
            PersonaResponse personaResponse = service.BuscarPorIdentificacion(txtId.Text);
         
                if (personaResponse.PersonaEncontrada)
                {
                   
                        table.Rows.Add(personaResponse.Persona.Identificacion,
                            personaResponse.Persona.Nombre, personaResponse.Persona.Edad, personaResponse.Persona.Sexo,
                            personaResponse.Persona.Pulsacion);
                        dataGridConsulta.DataSource = table;
                   
                }
                else
                {
                    MessageBox.Show("No existe el usuario registrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
         
            
            txtId.Text = "";

        }

        public DataTable CrearDataTable()
        {

            table.Columns.Add("Cedula");
            table.Columns.Add("Nombre");
            table.Columns.Add("Edad");
            table.Columns.Add("Sexo");
            table.Columns.Add("Pulsacion");

            dataGridConsulta.DataSource = table;
            return table;
           
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }
    }
          
          
            

         
            
        }
    

