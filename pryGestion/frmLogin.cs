using System;
using System.Windows.Forms;

namespace pryGestion
{
    public partial class frmLogin : Form
    {
        //Variables
        string Vusuario;
        string Vcontraseña;
        int    VcontadorLogin = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            //pasar datos
            Vusuario = txtUsuario.Text;
            Vcontraseña = txtContraseña.Text;
            if (Vusuario == "Mauri" && Vcontraseña == "2004")
            {
                frmPrincipal ventanadeRegistro = new frmPrincipal();
                ventanadeRegistro.ShowDialog();
                this.Hide();

            }
            else if ((Vusuario == "Fede" && Vcontraseña == "2005"))
            {
                frmPrincipal ventanadeRegistro = new frmPrincipal();
                ventanadeRegistro.ShowDialog();
                this.Hide();
            }
            else if ((Vusuario == "Maxi" && Vcontraseña == "2006"))
            {
                frmPrincipal ventanadeRegistro = new frmPrincipal();
                ventanadeRegistro.ShowDialog();
                this.Hide();
            }
            else if ((Vusuario == "Lucas" && Vcontraseña == "2007"))
            {
                frmPrincipal ventanadeRegistro = new frmPrincipal();
                ventanadeRegistro.ShowDialog();
                this.Hide();
            }

            else
            {
                VcontadorLogin++;
                if (VcontadorLogin == 3)
                {
                    MessageBox.Show("Demasiados Intentos ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                else
                {
                    MessageBox.Show("Dato incorrecto. intento:" + VcontadorLogin.ToString() + " de 3 ", "Login . Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }











        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            frmInicio frmInicio = new frmInicio();
            this.Hide();
            frmInicio.ShowDialog();
        }
    }
}
