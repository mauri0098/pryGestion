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
    public partial class fmrRegistrar : Form
    {
        public fmrRegistrar()
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
                if (ltsTipodeActividad.SelectedIndex != -1) 
                {
                    if (txtDetalleActivida.Text == "")
                    {
                        MessageBox.Show("falta completar el detalle", "cargar detalle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDetalleActivida.Focus();
                        
                
                    }
                    else
                    {
                        MessageBox.Show("vamos a grabar...");
                    }

                }
                else
                {
                    MessageBox.Show("seleccionbar un tipo de actividad", "cargar actividad");
                    ltsTipodeActividad.Focus();
                        
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
