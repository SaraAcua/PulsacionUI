using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PresentacionGUI
{
    public partial class FrmPrincipal : Form
    {
       
        public FrmPrincipal()
        {
            InitializeComponent();
           
        
        }



       
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }


        private void MenuPicture_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 230)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 230;
            }
        }

        private void PictureSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaxPicture_Click(object sender, EventArgs e)
        {
            
        }

        private void PictureRestaurar_Click(object sender, EventArgs e)
        {
            
        }

        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            int cont = this.PanelContenedor.Controls.Count;
            if (this.PanelContenedor.Controls.Count > 0)
            {
                for (int i = 0; i < cont; i++)
                {
                    this.PanelContenedor.Controls.RemoveAt(0);
                }

                
                
                Form fh = Formhijo as Form;
                fh.TopLevel = false;

                fh.Dock = DockStyle.Fill;
                this.PanelContenedor.Controls.Add(fh);
                this.PanelContenedor.Tag = fh;
                fh.Show();
            }


            //Form form = (Form)Formhijo;
            //form.TopLevel = false;
            //this.PanelContenedor.Controls.Add(form);

            //form.Show();

        }
       
        private void BtnRegistro_Click_1(object sender, EventArgs e)
        {
          
            AbrirFormEnPanel(new FrmGestionPersona());
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Consulta());
         
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmEliminar());
           
        }


        private void TimerFechaHora_Tick(object sender, EventArgs e)
        {
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormLogo());
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConsultaFiltrada_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormConsultaFiltrada());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmEditar());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Probar_conexion());
        }
    }
}