using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestion
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTipodeActividad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            
        
            if (dtpfecha.Value >= DateTime.Today)
            {
                if (lstActividad.SelectedIndex != -1) 
                {
                    if (txtDetalleActivida.Text == "")
                    {
                        MessageBox.Show("falta completar el detalle", "cargar detalle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDetalleActivida.Focus();

                         
                        if (optSi.Checked == true)
                        {
                             
                        }
                        else
                        {
                            optNo.Checked = true; 
                        }
                    }
                    else
                    {
                        MessageBox.Show("vamos a grabar...");

                        int n = dtgvRegistro.Rows.Add();

                        dtgvRegistro.Rows[n].Cells[0].Value = dtpfecha.Text;
                        dtgvRegistro.Rows[n].Cells[1].Value = lstActividad.Text;
                        dtgvRegistro.Rows[n].Cells[2].Value = txtDetalleActivida.Text;
                        dtgvRegistro.Rows[n].Cells[3].Value = optSi.Checked;
                    }

                }
                else
                {
                    MessageBox.Show("seleccionbar un tipo de actividad", "cargar actividad");
                    lstActividad.Focus();
                        
                }
             
            }
            else
            {
                MessageBox.Show("seleccionar una fecha actual o posterior a la de hoy", "cargar tarea", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpfecha.Value = DateTime.Today;
                dtpfecha.Focus();
            }
        }
    }
}
