using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Listas
{
    public partial class frmConfiguracionListas : Form
    {
        public frmConfiguracionListas()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            txtOfac.Text = Listas.Properties.Settings.Default.urlOfac;
            txtOnu.Text = Listas.Properties.Settings.Default.urlOnu;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Listas.Properties.Settings.Default.urlOfac = txtOfac.Text.Trim();
                Listas.Properties.Settings.Default.urlOnu = txtOnu.Text.Trim();
                Listas.Properties.Settings.Default.Save();
                Close();
                MessageBox.Show("Configuración guardada con exito", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {                
                    MessageBox.Show(ex.Message,"SERFINANSA::.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
