﻿using System;
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
            else
            {
                VcontadorLogin++;
                if (VcontadorLogin == 3) 
                {
                    MessageBox.Show("Demasiados Intentos ","error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                else
                {
                    MessageBox.Show("Dato incorrecto. intento:" + VcontadorLogin.ToString() + " de 3 ", "Login . Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

            
        }
    }
}
