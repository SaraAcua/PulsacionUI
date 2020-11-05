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
    public partial class FrmEditar : Form
    {
        PersonaService service = new PersonaService();
        public FrmEditar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
                {
                   
                    string mensaje = service.Modificar(TxtIdentificacion.Text,TxtNombre.Text, int.Parse(TxtEdad.Text),CmbSexo.Text);
                    MessageBox.Show(mensaje);

                }
                catch
                {
                    MessageBox.Show("No se pudo Modificar","Infromacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }

