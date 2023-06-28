namespace pryGestion
{
    partial class frmPrincipal
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
            this.cmdRegistrarActividad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdRegistrarActividad
            // 
            this.cmdRegistrarActividad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarActividad.Location = new System.Drawing.Point(72, 186);
            this.cmdRegistrarActividad.Name = "cmdRegistrarActividad";
            this.cmdRegistrarActividad.Size = new System.Drawing.Size(125, 48);
            this.cmdRegistrarActividad.TabIndex = 0;
            this.cmdRegistrarActividad.Text = "Registrar Actividad";
            this.cmdRegistrarActividad.UseVisualStyleBackColor = true;
            this.cmdRegistrarActividad.Click += new System.EventHandler(this.cmdRegistrarActividad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryGestion.Properties.Resources.b2ap3_large_Ilustracion_publicacion_control_actividades;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 245);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdRegistrarActividad);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Tareas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRegistrarActividad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}