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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridConsulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmboSexo = new System.Windows.Forms.ComboBox();
            this.BtnConsultarFiltro = new System.Windows.Forms.Button();
            this.btnConsultarNombre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridConsulta
            // 
            this.dataGridConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridConsulta.ColumnHeadersHeight = 25;
            this.dataGridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridConsulta.EnableHeadersVisualStyles = false;
            this.dataGridConsulta.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridConsulta.Location = new System.Drawing.Point(41, 151);
            this.dataGridConsulta.Name = "dataGridConsulta";
            this.dataGridConsulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridConsulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dataGridConsulta.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridConsulta.Size = new System.Drawing.Size(451, 221);
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
            // FormConsultaFiltrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 436);
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
    }
}