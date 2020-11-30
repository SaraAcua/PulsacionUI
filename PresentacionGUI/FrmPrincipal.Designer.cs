namespace PresentacionGUI
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnConsultaFiltrada = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnRegistro = new System.Windows.Forms.Button();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuPicture = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TimerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.MenuVertical.SuspendLayout();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPicture)).BeginInit();
            this.PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.AutoScroll = true;
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(37)))), ((int)(((byte)(86)))));
            this.MenuVertical.Controls.Add(this.button4);
            this.MenuVertical.Controls.Add(this.btnConsultaFiltrada);
            this.MenuVertical.Controls.Add(this.button3);
            this.MenuVertical.Controls.Add(this.button2);
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.BtnRegistro);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(235, 472);
            this.MenuVertical.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(23, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 40);
            this.button4.TabIndex = 9;
            this.button4.Text = "       Probar conexion";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnConsultaFiltrada
            // 
            this.btnConsultaFiltrada.FlatAppearance.BorderSize = 0;
            this.btnConsultaFiltrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaFiltrada.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaFiltrada.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultaFiltrada.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaFiltrada.Image")));
            this.btnConsultaFiltrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaFiltrada.Location = new System.Drawing.Point(19, 269);
            this.btnConsultaFiltrada.Name = "btnConsultaFiltrada";
            this.btnConsultaFiltrada.Size = new System.Drawing.Size(205, 40);
            this.btnConsultaFiltrada.TabIndex = 8;
            this.btnConsultaFiltrada.Text = "       Consulta filtrada";
            this.btnConsultaFiltrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaFiltrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultaFiltrada.UseVisualStyleBackColor = true;
            this.btnConsultaFiltrada.Click += new System.EventHandler(this.btnConsultaFiltrada_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Image = global::PresentacionGUI.Properties.Resources.iconfinder_pencil_writing_write_edit_pen_3643749;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(19, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "       Editar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(19, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "       Eliminar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(19, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "       Consulta";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.FlatAppearance.BorderSize = 0;
            this.BtnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistro.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnRegistro.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistro.Image")));
            this.BtnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistro.Location = new System.Drawing.Point(19, 88);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Size = new System.Drawing.Size(179, 40);
            this.BtnRegistro.TabIndex = 4;
            this.BtnRegistro.Text = "       Registro";
            this.BtnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistro.UseVisualStyleBackColor = true;
            this.BtnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click_1);
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelTitulo.Controls.Add(this.pictureBox1);
            this.PanelTitulo.Controls.Add(this.MenuPicture);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(235, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(545, 36);
            this.PanelTitulo.TabIndex = 2;
            this.PanelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitulo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::PresentacionGUI.Properties.Resources.iconfinder_Artboard_1_3030698;
            this.pictureBox1.Location = new System.Drawing.Point(53, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MenuPicture
            // 
            this.MenuPicture.Image = ((System.Drawing.Image)(resources.GetObject("MenuPicture.Image")));
            this.MenuPicture.Location = new System.Drawing.Point(6, 3);
            this.MenuPicture.Name = "MenuPicture";
            this.MenuPicture.Size = new System.Drawing.Size(44, 30);
            this.MenuPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuPicture.TabIndex = 0;
            this.MenuPicture.TabStop = false;
            this.MenuPicture.Click += new System.EventHandler(this.MenuPicture_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelContenedor.Controls.Add(this.pictureBox2);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelContenedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelContenedor.Location = new System.Drawing.Point(235, 36);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(545, 436);
            this.PanelContenedor.TabIndex = 3;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PresentacionGUI.Properties.Resources.iconfinder_medical_healthcare_hospital_41_4082072;
            this.pictureBox2.Location = new System.Drawing.Point(140, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 256);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // TimerFechaHora
            // 
            this.TimerFechaHora.Enabled = true;
            this.TimerFechaHora.Tick += new System.EventHandler(this.TimerFechaHora_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 472);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.MenuVertical);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmPrincipal";
            this.Text = "Gestion de pulsaciones";
            this.MenuVertical.ResumeLayout(false);
            this.PanelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPicture)).EndInit();
            this.PanelContenedor.ResumeLayout(false);
            this.PanelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel PanelTitulo;
        private System.Windows.Forms.PictureBox MenuPicture;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnRegistro;
        private System.Windows.Forms.Timer TimerFechaHora;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnConsultaFiltrada;
        private System.Windows.Forms.Button button4;
    }
}

