using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lnkConfiguracion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmConfigConexion frmConfig = new frmConfigConexion();
            frmConfig.ShowDialog(this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaConexion.Conexion.iniciar( Properties.Settings.Default.BaseDatos, Properties.Settings.Default.Puerto, Properties.Settings.Default.Servidor, txtUser.Text.Trim(), txtPass.Text.Trim());
                CapaConexion.Conexion  Con = new CapaConexion.Conexion();
                Con.Conectar();
                Con.Desconectar();
                CapaConexion.Usuario.Nombre = txtUser.Text.Trim();
                CapaConexion.Usuario.Contraseña = txtPass.Text.Trim();
                CapaConexion.Usuario.Logueado = true;
                Con = null;
                GC.Collect();
                Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
