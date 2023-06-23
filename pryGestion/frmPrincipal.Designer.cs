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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdRegistrarActividad
            // 
            this.cmdRegistrarActividad.Location = new System.Drawing.Point(267, 162);
            this.cmdRegistrarActividad.Name = "cmdRegistrarActividad";
            this.cmdRegistrarActividad.Size = new System.Drawing.Size(144, 47);
            this.cmdRegistrarActividad.TabIndex = 0;
            this.cmdRegistrarActividad.Text = "Registrar Actividad";
            this.cmdRegistrarActividad.UseVisualStyleBackColor = true;
            this.cmdRegistrarActividad.Click += new System.EventHandler(this.cmdRegistrarActividad_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmdRegistrarActividad);
            this.Name = "frmPrincipal";
            this.Text = "Gestion de Tareas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRegistrarActividad;
        private System.Windows.Forms.Button button2;
    }
}