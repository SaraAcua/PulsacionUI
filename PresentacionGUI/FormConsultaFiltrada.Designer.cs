namespace PresentacionGUI
{
    partial class FormConsultaFiltrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridConsulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmboSexo = new System.Windows.Forms.ComboBox();
            this.BtnConsultarFiltro = new System.Windows.Forms.Button();
            this.btnConsultarNombre = new System.Windows.Forms.Button();
            this.lblConteo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridConsulta
            // 
            this.dataGridConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridConsulta.ColumnHeadersHeight = 25;
            this.dataGridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridConsulta.EnableHeadersVisualStyles = false;
            this.dataGridConsulta.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridConsulta.Location = new System.Drawing.Point(38, 131);
            this.dataGridConsulta.Name = "dataGridConsulta";
            this.dataGridConsulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridConsulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dataGridConsulta.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridConsulta.Size = new System.Drawing.Size(446, 91);
            this.dataGridConsulta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtrar por nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtrar por sexo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(129, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // cmboSexo
            // 
            this.cmboSexo.FormattingEnabled = true;
            this.cmboSexo.Items.AddRange(new object[] {
            "-----",
            "Todos",
            "F",
            "M"});
            this.cmboSexo.Location = new System.Drawing.Point(129, 83);
            this.cmboSexo.Name = "cmboSexo";
            this.cmboSexo.Size = new System.Drawing.Size(100, 21);
            this.cmboSexo.TabIndex = 8;
            // 
            // BtnConsultarFiltro
            // 
            this.BtnConsultarFiltro.BackColor = System.Drawing.Color.Teal;
            this.BtnConsultarFiltro.FlatAppearance.BorderSize = 0;
            this.BtnConsultarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultarFiltro.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultarFiltro.Location = new System.Drawing.Point(235, 86);
            this.BtnConsultarFiltro.Name = "BtnConsultarFiltro";
            this.BtnConsultarFiltro.Size = new System.Drawing.Size(107, 29);
            this.BtnConsultarFiltro.TabIndex = 9;
            this.BtnConsultarFiltro.Text = "Consultar";
            this.BtnConsultarFiltro.UseVisualStyleBackColor = false;
            this.BtnConsultarFiltro.Click += new System.EventHandler(this.BtnConsultarFiltro_Click);
            // 
            // btnConsultarNombre
            // 
            this.btnConsultarNombre.BackColor = System.Drawing.Color.Teal;
            this.btnConsultarNombre.FlatAppearance.BorderSize = 0;
            this.btnConsultarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarNombre.Location = new System.Drawing.Point(235, 42);
            this.btnConsultarNombre.Name = "btnConsultarNombre";
            this.btnConsultarNombre.Size = new System.Drawing.Size(107, 29);
            this.btnConsultarNombre.TabIndex = 10;
            this.btnConsultarNombre.Text = "Consultar";
            this.btnConsultarNombre.UseVisualStyleBackColor = false;
            this.btnConsultarNombre.Click += new System.EventHandler(this.btnConsultarNombre_Click);
            // 
            // lblConteo
            // 
            this.lblConteo.AutoSize = true;
            this.lblConteo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConteo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConteo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteo.Location = new System.Drawing.Point(253, 235);
            this.lblConteo.Name = "lblConteo";
            this.lblConteo.Size = new System.Drawing.Size(23, 26);
            this.lblConteo.TabIndex = 11;
            this.lblConteo.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total ";
            // 
            // FormConsultaFiltrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblConteo);
            this.Controls.Add(this.btnConsultarNombre);
            this.Controls.Add(this.BtnConsultarFiltro);
            this.Controls.Add(this.cmboSexo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultaFiltrada";
            this.Text = "FormConsultaFiltrada";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmboSexo;
        private System.Windows.Forms.Button BtnConsultarFiltro;
        private System.Windows.Forms.Button btnConsultarNombre;
        private System.Windows.Forms.Label lblConteo;
        private System.Windows.Forms.Label label3;
    }
}