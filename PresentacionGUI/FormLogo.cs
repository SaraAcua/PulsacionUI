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
    public partial class FormLogo : Form
    {
        public FormLogo()
        {
            InitializeComponent();
        }

        private void timerHoraFecha_Tick(object sender, EventArgs e)
        {
           
            
                LblHora.Text = DateTime.Now.ToLongTimeString();
                LblFecha.Text = DateTime.Now.ToString("dddd MMMM yyy");

            }

   
    }
    }

