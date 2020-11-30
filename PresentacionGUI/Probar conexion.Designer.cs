
namespace PresentacionGUI
{
    partial class Probar_conexion
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
            this.btnMostarConexion = new System.Windows.Forms.Button();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtEstadoConexion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMostarConexion
            // 
            this.btnMostarConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostarConexion.Location = new System.Drawing.Point(141, 195);
            this.btnMostarConexion.Name = "btnMostarConexion";
            this.btnMostarConexion.Size = new System.Drawing.Size(186, 36);
            this.btnMostarConexion.TabIndex = 0;
            this.btnMostarConexion.Text = "Mostrar datos";
            this.btnMostarConexion.UseVisualStyleBackColor = true;
            this.btnMostarConexion.Click += new System.EventHandler(this.btnMostarConexion_Click);
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(108, 41);
            this.txtVersion.Multiline = true;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(268, 48);
            this.txtVersion.TabIndex = 1;
            // 
            // txtEstadoConexion
            // 
            this.txtEstadoConexion.Location = new System.Drawing.Point(108, 102);
            this.txtEstadoConexion.Multiline = true;
            this.txtEstadoConexion.Name = "txtEstadoConexion";
            this.txtEstadoConexion.Size = new System.Drawing.Size(268, 57);
            this.txtEstadoConexion.TabIndex = 2;
            // 
            // Probar_conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(598, 430);
            this.Controls.Add(this.txtEstadoConexion);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.btnMostarConexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Probar_conexion";
            this.Text = "Probar_conexion";
            this.Load += new System.EventHandler(this.Probar_conexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostarConexion;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtEstadoConexion;
    }
}