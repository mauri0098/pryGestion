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
            this.mrcReunion.SuspendLayout();
            this.mrcTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipodeActividad
            // 
            this.lblTipodeActividad.AutoSize = true;
            this.lblTipodeActividad.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodeActividad.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTipodeActividad.Location = new System.Drawing.Point(8, 47);
            this.lblTipodeActividad.Name = "lblTipodeActividad";
            this.lblTipodeActividad.Size = new System.Drawing.Size(110, 17);
            this.lblTipodeActividad.TabIndex = 0;
            this.lblTipodeActividad.Text = "Tipo de Actividad";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblFecha.Location = new System.Drawing.Point(12, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 17);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDetalleActividad
            // 
            this.lblDetalleActividad.AutoSize = true;
            this.lblDetalleActividad.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleActividad.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDetalleActividad.Location = new System.Drawing.Point(9, 87);
            this.lblDetalleActividad.Name = "lblDetalleActividad";
            this.lblDetalleActividad.Size = new System.Drawing.Size(109, 17);
            this.lblDetalleActividad.TabIndex = 3;
            this.lblDetalleActividad.Text = "Detalle  Actividad";
            this.lblDetalleActividad.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(77, 9);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 4;
            // 
            // mrcReunion
            // 
            this.mrcReunion.Controls.Add(this.optNo);
            this.mrcReunion.Controls.Add(this.optSi);
            this.mrcReunion.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcReunion.ForeColor = System.Drawing.Color.Goldenrod;
            this.mrcReunion.Location = new System.Drawing.Point(15, 230);
            this.mrcReunion.Name = "mrcReunion";
            this.mrcReunion.Size = new System.Drawing.Size(254, 134);
            this.mrcReunion.TabIndex = 8;
            this.mrcReunion.TabStop = false;
            this.mrcReunion.Text = "Reunion";
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.Checked = true;
            this.optNo.Location = new System.Drawing.Point(41, 62);
            this.optNo.Name = "optNo";
            this.optNo.Size = new System.Drawing.Size(44, 21);
            this.optNo.TabIndex = 1;
            this.optNo.TabStop = true;
            this.optNo.Text = "No";
            this.optNo.UseVisualStyleBackColor = true;
            // 
            // optSi
            // 
            this.optSi.AutoSize = true;
            this.optSi.Location = new System.Drawing.Point(41, 29);
            this.optSi.Name = "optSi";
            this.optSi.Size = new System.Drawing.Size(36, 21);
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
            this.mrcTareas.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcTareas.ForeColor = System.Drawing.Color.Goldenrod;
            this.mrcTareas.Location = new System.Drawing.Point(11, 370);
            this.mrcTareas.Name = "mrcTareas";
            this.mrcTareas.Size = new System.Drawing.Size(266, 100);
            this.mrcTareas.TabIndex = 9;
            this.mrcTareas.TabStop = false;
            this.mrcTareas.Text = "Tareas";
            // 
            // chkDebate
            // 
            this.chkDebate.AutoSize = true;
            this.chkDebate.Location = new System.Drawing.Point(152, 62);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(69, 21);
            this.chkDebate.TabIndex = 3;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            // 
            // chkNotasReunion
            // 
            this.chkNotasReunion.AutoSize = true;
            this.chkNotasReunion.Location = new System.Drawing.Point(31, 56);
            this.chkNotasReunion.Name = "chkNotasReunion";
            this.chkNotasReunion.Size = new System.Drawing.Size(110, 21);
            this.chkNotasReunion.TabIndex = 2;
            this.chkNotasReunion.Text = "Notas reuniòn";
            this.chkNotasReunion.UseVisualStyleBackColor = true;
            // 
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Location = new System.Drawing.Point(152, 33);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(102, 21);
            this.chkInvestigacion.TabIndex = 1;
            this.chkInvestigacion.Text = "Investigación";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
            // 
            // chkRepositorio
            // 
            this.chkRepositorio.AutoSize = true;
            this.chkRepositorio.Location = new System.Drawing.Point(31, 33);
            this.chkRepositorio.Name = "chkRepositorio";
            this.chkRepositorio.Size = new System.Drawing.Size(95, 21);
            this.chkRepositorio.TabIndex = 0;
            this.chkRepositorio.Text = "Repositorio";
            this.chkRepositorio.UseVisualStyleBackColor = true;
            // 
            // cmdVolver
            // 
            this.cmdVolver.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolver.Location = new System.Drawing.Point(43, 524);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 11;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrar.Location = new System.Drawing.Point(163, 524);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrar.TabIndex = 12;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // lstActividad
            // 
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Items.AddRange(new object[] {
            "Actividad1",
            "Actividad2",
            "Actividad3"});
            this.lstActividad.Location = new System.Drawing.Point(124, 47);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(121, 21);
            this.lstActividad.TabIndex = 14;
            // 
            // txtDetalleActivida
            // 
            this.txtDetalleActivida.Location = new System.Drawing.Point(11, 107);
            this.txtDetalleActivida.Multiline = true;
            this.txtDetalleActivida.Name = "txtDetalleActivida";
            this.txtDetalleActivida.Size = new System.Drawing.Size(265, 117);
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
            this.dtgvRegistro.Location = new System.Drawing.Point(282, 156);
            this.dtgvRegistro.Name = "dtgvRegistro";
            this.dtgvRegistro.Size = new System.Drawing.Size(524, 352);
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
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 578);
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
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.mrcReunion.ResumeLayout(false);
            this.mrcReunion.PerformLayout();
            this.mrcTareas.ResumeLayout(false);
            this.mrcTareas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).EndInit();
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
    }
}