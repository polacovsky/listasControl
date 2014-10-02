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
    public partial class frmGenerarPlanoHistorico : Form
    {
        BindingList<Fuente> Fuentes ;
        BindingSource bs = new BindingSource();
        public frmGenerarPlanoHistorico()
        {
            InitializeComponent();
        }

        private void frmGenerarPlano_Load(object sender, EventArgs e)
        {
            try
            {
                Fuentes = new BindingList<Fuente>( Funciones.getFuentes());
                bs.DataSource = Fuentes;
                cmbFuentes.DataSource = bs;
                cmbFuentes.DisplayMember = "nombre";
                cmbFuentes.ValueMember="codigo";
                cmbFuentes.SelectedIndex = -1;
                cmbFuentes.Enabled = false;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

      

        private void btnGenerar_Click(object sender, EventArgs e)
        {
                 try
                 {
                     SaveFileDialog sd = new SaveFileDialog();                
                     DialogResult result = sd.ShowDialog();
                     if (result != DialogResult.OK) return;
                     Funciones.generateFileHistorico(sd.FileName, chkFuente.Checked ? (String)cmbFuentes.SelectedValue : null, dpFechaInicial.Value, dpFechaFinal.Value);
                     MessageBox.Show("El archivo fué generado satisfactoriamente.", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 catch (Exception ex) {
                     MessageBox.Show(ex.Message, "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkFuente_CheckedChanged(object sender, EventArgs e)
        {
            cmbFuentes.SelectedIndex = -1;
            cmbFuentes.Enabled = chkFuente.Checked;
        }
    }
}
