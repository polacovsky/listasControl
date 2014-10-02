using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Configuracion
{
    public partial class frmHomoPaises : BasicForms.frmMaestroDesconectado
    {
        public frmHomoPaises()
        {
            InitializeComponent();
        }

        public override void cargarDatos()
        {
            if ((this.DS_MAESTRO.Tables["TABLA"] != null))
            {
                this.DS_MAESTRO.Tables.Clear();
            }
            this.DS_MAESTRO.Tables.Add("TABLA");
            MyConex.LlenarDatosDirecto(this.DA_MAESTRO, this.DS_MAESTRO.Tables["TABLA"], "vst_homo_paises");
            //'ASIGNO LA TABLA 1 AL BINDING SOURCE MAESTRO
            this.DV_MAESTRO = new DataView(this.DS_MAESTRO.Tables["TABLA"]);
            this.BS_MAESTRO.DataSource = DV_MAESTRO;
            //'ENLAZO LOS TEXTBOX a combos	              
            this.txtFuente.DataBindings.Add("text", BS_MAESTRO, "codFuente",true);
            this.txtNombre.DataBindings.Add("text", BS_MAESTRO, "nombre", true);
            this.txtCodCausal.DataBindings.Add("text", BS_MAESTRO, "codigoIBS", true);
            //this.txtCausalIBS.DataBindings.Add("text", BS_MAESTRO, "causalIBS", true); 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = BS_MAESTRO;
        }

        public override void editando(bool SioNo)
        {
            foreach (Control cnt in gbDatos.Controls)
            {
                if (cnt is TextBox)
                {
                   ((TextBox) cnt).ReadOnly = !SioNo;
                }
                else if (cnt is LinkLabel) { cnt.Enabled = SioNo; }
            }
            txtFiltro.Enabled = !SioNo;
            txtFuente.ReadOnly = true;
            txtCausalIBS.ReadOnly = true;
            txtCodCausal.ReadOnly = true;
            dataGridView1.Enabled = !SioNo;           
            if ((SioNo))
            {
                DesactivarBarra();
            }
            else
            {
                ActivarBarra();
            }
        }

        public override void construircomandos()
        {
            //INSERT
            DA_MAESTRO.InsertCommand = new MySqlCommand("add_homoPais", MyConex.MyConexion);
            DA_MAESTRO.InsertCommand.CommandType = CommandType.StoredProcedure;
            DA_MAESTRO.InsertCommand.Parameters.Add("pCodFuente", MySqlDbType.VarChar, 4, "codFuente");
            DA_MAESTRO.InsertCommand.Parameters.Add("pNombre", MySqlDbType.VarChar, 45, "nombre");
            DA_MAESTRO.InsertCommand.Parameters.Add("pCodigoIBS", MySqlDbType.VarChar, 45, "pCodigoIBS");          

            // UPDATE        
            DA_MAESTRO.UpdateCommand = new MySqlCommand("edit_homoCausal", MyConex.MyConexion);
            DA_MAESTRO.UpdateCommand.CommandType = CommandType.StoredProcedure;
            DA_MAESTRO.UpdateCommand.Parameters.Add("pid", MySqlDbType.Int32, 10, "id");
            DA_MAESTRO.UpdateCommand.Parameters.Add("pCodFuente", MySqlDbType.VarChar, 4, "codFuente");
            DA_MAESTRO.UpdateCommand.Parameters.Add("pNombre", MySqlDbType.VarChar, 45, "nombre");
            DA_MAESTRO.UpdateCommand.Parameters.Add("pCodCausalIBS", MySqlDbType.VarChar, 45, "codCausalIBS");
        }

        public override bool valido(TiposOperaciones operacion)
        {
            if (string.IsNullOrEmpty(txtFuente.Text)) {
                MessageBox.Show("Debe especificar un código.", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (string.IsNullOrEmpty(txtFuente.Text))
            {
                MessageBox.Show("Debe especificar un nombre.", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
           
            BS_MAESTRO.Filter = CapaConexion.Funciones.devolverfiltrado("nombre", txtFiltro.Text);
        }

        private void linkFuente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BasicForms.frmSeleccionar frm = new BasicForms.frmSeleccionar("get_fuentes", txtFuente, new string[,] { { "codigo", "Código" } }, "codigo");
            frm.ShowDialog();
        }

        private void linkCausal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BasicForms.frmSeleccionar frm = new BasicForms.frmSeleccionar("get_paisesIBS", txtCodCausal, new string[,] { { "codigo", "Código" }, { "nombre", "Nombre" } }, "codigo");
            frm.ShowDialog();
        }

        private void txtCodCausal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtCausalIBS.Text = (string)MyConex.DevolverDato("get_NombrepaisIBS", "pCodigo", txtCodCausal.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
