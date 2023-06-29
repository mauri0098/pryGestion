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
        //declaracion de matriz
        string[,] MatrizRegistrodeActividad
              = new string[5, 5];
        
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
            string varReunion = "";
            string varTarea = "";
            if (dtpfecha.Value >= DateTime.Today)
            {
                if (lstActividad.SelectedIndex != -1) 
                {
                    if (txtDetalleActivida.Text == "")
                    {
                        MessageBox.Show("falta completar el detalle", "cargar detalle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDetalleActivida.Focus();

                    }
                    else
                    {


                        MessageBox.Show("vamos a grabar...");




                        if (optSi.Checked == true)
                        {
                            varReunion = "SI";
                        }
                        else
                        {
                            varReunion = "NO";
                        }
                        if (chkDebate.Checked)
                        {
                            varTarea = "Debate";

                        }
                        if (chkInvestigacion.Checked)
                        {
                            varTarea = "Investigacion";

                        }
                        if (chkNotasReunion.Checked)
                        {
                            varTarea = "Notas";

                        }
                        if (chkRepositorio.Checked)
                        {
                            varTarea = "Repositorio";

                        }


                        int n = dtgvRegistro.Rows.Add();

                        dtgvRegistro.Rows[n].Cells[0].Value = dtpfecha.Text;
                        dtgvRegistro.Rows[n].Cells[1].Value = lstActividad.Text;
                        dtgvRegistro.Rows[n].Cells[2].Value = txtDetalleActivida.Text;
                        dtgvRegistro.Rows[n].Cells[3].Value = varReunion;
                        dtgvRegistro.Rows[n].Cells[4].Value = varTarea;
                        
                        

                        //Regitrar Matriz
                        
                        MatrizRegistrodeActividad[n,0] = dtpfecha.Text;
                        MatrizRegistrodeActividad[n,1] = lstActividad.Text;
                        MatrizRegistrodeActividad[n,2] = txtDetalleActivida.Text;
                        MatrizRegistrodeActividad[n,3] = varReunion;
                        MatrizRegistrodeActividad[n,4] = varTarea;

                        lstActividad.Text = "";
                        txtDetalleActivida.Text = "";
                        varReunion = "";
                        varTarea = "";


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

        private void chkDebate_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            this.Hide();
            frmPrincipal.ShowDialog();
        }
    }
}
