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
    public partial class frmConfigConexion : Form
    {
        public frmConfigConexion()
        {
            InitializeComponent();
        }

        private void frmConfigConexion_Load(object sender, EventArgs e)
        {
            txtBaseDatos.Text = Properties.Settings.Default.BaseDatos;
            txtServer.Text = Properties.Settings.Default.Servidor;
            txtPuerto.Text = Properties.Settings.Default.Puerto;     
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.BaseDatos = txtBaseDatos.Text;                
                Properties.Settings.Default.Servidor = txtServer.Text;
                Properties.Settings.Default.Puerto = txtPuerto.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Configuración guardada con exito", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
