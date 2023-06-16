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
    public partial class frmLogin : Form
    {
        //Variables
        string Vusuario;
        string Vcontraseña;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            //pasar datos
            Vusuario = txtUsuario.Text;
            Vcontraseña = txtContraseña.Text;
            if (Vusuario == "Mauri" && Vcontraseña == "123")
            {

            }
        }
    }
}
