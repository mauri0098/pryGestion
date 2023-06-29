namespace pryGestion
{
    partial class frmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            this.lblTipodeActividad = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDetalleActividad = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.mrcReunion = new System.Windows.Forms.GroupBox();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.optSi = new System.Windows.Forms.RadioButton();
            this.mrcTareas = new System.Windows.Forms.GroupBox();
            this.chkDebate = new System.Windows.Forms.CheckBox();
            this.chkNotasReunion = new System.Windows.Forms.CheckBox();
            this.chkInvestigacion = new System.Windows.Forms.CheckBox();
            this.chkRepositorio = new System.Windows.Forms.CheckBox();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.txtDetalleActivida = new System.Windows.Forms.TextBox();
            this.dtgvRegistro = new System.Windows.Forms.DataGridView();
            this.dtgvFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvReunion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvTareas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mrcReunion.SuspendLayout();
            this.mrcTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipodeActividad
            // 
            this.lblTipodeActividad.AutoSize = true;
            this.lblTipodeActividad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodeActividad.ForeColor = System.Drawing.Color.Blue;
            this.lblTipodeActividad.Location = new System.Drawing.Point(7, 49);
            this.lblTipodeActividad.Name = "lblTipodeActividad";
            this.lblTipodeActividad.Size = new System.Drawing.Size(128, 19);
            this.lblTipodeActividad.TabIndex = 0;
            this.lblTipodeActividad.Text = "Tipo de Actividad";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Blue;
            this.lblFecha.Location = new System.Drawing.Point(11, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 19);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDetalleActividad
            // 
            this.lblDetalleActividad.AutoSize = true;
            this.lblDetalleActividad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleActividad.ForeColor = System.Drawing.Color.Blue;
            this.lblDetalleActividad.Location = new System.Drawing.Point(7, 83);
            this.lblDetalleActividad.Name = "lblDetalleActividad";
            this.lblDetalleActividad.Size = new System.Drawing.Size(129, 19);
            this.lblDetalleActividad.TabIndex = 3;
            this.lblDetalleActividad.Text = "Detalle  Actividad";
            this.lblDetalleActividad.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(69, 9);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 4;
            // 
            // mrcReunion
            // 
            this.mrcReunion.Controls.Add(this.optNo);
            this.mrcReunion.Controls.Add(this.optSi);
            this.mrcReunion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcReunion.ForeColor = System.Drawing.Color.Blue;
            this.mrcReunion.Location = new System.Drawing.Point(11, 230);
            this.mrcReunion.Name = "mrcReunion";
            this.mrcReunion.Size = new System.Drawing.Size(267, 134);
            this.mrcReunion.TabIndex = 8;
            this.mrcReunion.TabStop = false;
            this.mrcReunion.Text = "Reunion";
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.Checked = true;
            this.optNo.ForeColor = System.Drawing.Color.Blue;
            this.optNo.Location = new System.Drawing.Point(41, 66);
            this.optNo.Name = "optNo";
            this.optNo.Size = new System.Drawing.Size(47, 23);
            this.optNo.TabIndex = 1;
            this.optNo.TabStop = true;
            this.optNo.Text = "No";
            this.optNo.UseVisualStyleBackColor = true;
            // 
            // optSi
            // 
            this.optSi.AutoSize = true;
            this.optSi.ForeColor = System.Drawing.Color.Blue;
            this.optSi.Location = new System.Drawing.Point(41, 29);
            this.optSi.Name = "optSi";
            this.optSi.Size = new System.Drawing.Size(39, 23);
            this.optSi.TabIndex = 0;
            this.optSi.Text = "Si";
            this.optSi.UseVisualStyleBackColor = true;
            // 
            // mrcTareas
            // 
            this.mrcTareas.Controls.Add(this.chkDebate);
            this.mrcTareas.Controls.Add(this.chkNotasReunion);
            this.mrcTareas.Controls.Add(this.chkInvestigacion);
            this.mrcTareas.Controls.Add(this.chkRepositorio);
            this.mrcTareas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcTareas.ForeColor = System.Drawing.Color.Blue;
            this.mrcTareas.Location = new System.Drawing.Point(11, 370);
            this.mrcTareas.Name = "mrcTareas";
            this.mrcTareas.Size = new System.Drawing.Size(267, 100);
            this.mrcTareas.TabIndex = 9;
            this.mrcTareas.TabStop = false;
            this.mrcTareas.Text = "Tareas";
            // 
            // chkDebate
            // 
            this.chkDebate.AutoSize = true;
            this.chkDebate.Location = new System.Drawing.Point(144, 55);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(77, 23);
            this.chkDebate.TabIndex = 3;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            this.chkDebate.CheckedChanged += new System.EventHandler(this.chkDebate_CheckedChanged);
            // 
            // chkNotasReunion
            // 
            this.chkNotasReunion.AutoSize = true;
            this.chkNotasReunion.Location = new System.Drawing.Point(17, 55);
            this.chkNotasReunion.Name = "chkNotasReunion";
            this.chkNotasReunion.Size = new System.Drawing.Size(126, 23);
            this.chkNotasReunion.TabIndex = 2;
            this.chkNotasReunion.Text = "Notas reuniòn";
            this.chkNotasReunion.UseVisualStyleBackColor = true;
            // 
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Location = new System.Drawing.Point(144, 26);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(117, 23);
            this.chkInvestigacion.TabIndex = 1;
            this.chkInvestigacion.Text = "Investigación";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
            // 
            // chkRepositorio
            // 
            this.chkRepositorio.AutoSize = true;
            this.chkRepositorio.Location = new System.Drawing.Point(17, 26);
            this.chkRepositorio.Name = "chkRepositorio";
            this.chkRepositorio.Size = new System.Drawing.Size(107, 23);
            this.chkRepositorio.TabIndex = 0;
            this.chkRepositorio.Text = "Repositorio";
            this.chkRepositorio.UseVisualStyleBackColor = true;
            // 
            // cmdVolver
            // 
            this.cmdVolver.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolver.Location = new System.Drawing.Point(148, 488);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 32);
            this.cmdVolver.TabIndex = 11;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrar.Location = new System.Drawing.Point(28, 488);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(75, 32);
            this.cmdRegistrar.TabIndex = 12;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // lstActividad
            // 
            this.lstActividad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Items.AddRange(new object[] {
            "Producción forestal",
            "Agricultura",
            "Pecuaria",
            "Industria",
            "Comercio",
            "TurismoTenencia de la tierra"});
            this.lstActividad.Location = new System.Drawing.Point(148, 46);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(121, 27);
            this.lstActividad.TabIndex = 14;
            // 
            // txtDetalleActivida
            // 
            this.txtDetalleActivida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalleActivida.Location = new System.Drawing.Point(11, 107);
            this.txtDetalleActivida.Multiline = true;
            this.txtDetalleActivida.Name = "txtDetalleActivida";
            this.txtDetalleActivida.Size = new System.Drawing.Size(267, 117);
            this.txtDetalleActivida.TabIndex = 15;
            // 
            // dtgvRegistro
            // 
            this.dtgvRegistro.AllowUserToOrderColumns = true;
            this.dtgvRegistro.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgvFecha,
            this.dtgvActividad,
            this.dtgvDetalle,
            this.dtgvReunion,
            this.dtgvTareas});
            this.dtgvRegistro.Location = new System.Drawing.Point(293, 198);
            this.dtgvRegistro.Name = "dtgvRegistro";
            this.dtgvRegistro.Size = new System.Drawing.Size(546, 352);
            this.dtgvRegistro.TabIndex = 16;
            // 
            // dtgvFecha
            // 
            this.dtgvFecha.HeaderText = "Fecha";
            this.dtgvFecha.Name = "dtgvFecha";
            // 
            // dtgvActividad
            // 
            this.dtgvActividad.HeaderText = "Actividad";
            this.dtgvActividad.Name = "dtgvActividad";
            // 
            // dtgvDetalle
            // 
            this.dtgvDetalle.HeaderText = "Detalle";
            this.dtgvDetalle.Name = "dtgvDetalle";
            // 
            // dtgvReunion
            // 
            this.dtgvReunion.HeaderText = "Reunion";
            this.dtgvReunion.Name = "dtgvReunion";
            // 
            // dtgvTareas
            // 
            this.dtgvTareas.HeaderText = "Tareas";
            this.dtgvTareas.Name = "dtgvTareas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryGestion.Properties.Resources._1431098283_691735_1431098420_noticia_normal__1_;
            this.pictureBox1.Location = new System.Drawing.Point(293, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 568);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgvRegistro);
            this.Controls.Add(this.txtDetalleActivida);
            this.Controls.Add(this.lstActividad);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.mrcTareas);
            this.Controls.Add(this.mrcReunion);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.lblDetalleActividad);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTipodeActividad);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.mrcReunion.ResumeLayout(false);
            this.mrcReunion.PerformLayout();
            this.mrcTareas.ResumeLayout(false);
            this.mrcTareas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipodeActividad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDetalleActividad;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.GroupBox mrcReunion;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.RadioButton optSi;
        private System.Windows.Forms.GroupBox mrcTareas;
        private System.Windows.Forms.CheckBox chkDebate;
        private System.Windows.Forms.CheckBox chkNotasReunion;
        private System.Windows.Forms.CheckBox chkInvestigacion;
        private System.Windows.Forms.CheckBox chkRepositorio;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.TextBox txtDetalleActivida;
        private System.Windows.Forms.DataGridView dtgvRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvReunion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgvTareas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}