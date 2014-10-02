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
    public partial class frmTiposID_IBS : BasicForms.frmMaestroDesconectado
    {
        public frmTiposID_IBS()
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
            MyConex.LlenarDatosDirecto(this.DA_MAESTRO, this.DS_MAESTRO.Tables["TABLA"], "ibs_tiposid");
            //'ASIGNO LA TABLA 1 AL BINDING SOURCE MAESTRO
            this.DV_MAESTRO = new DataView(this.DS_MAESTRO.Tables["TABLA"]);
            this.BS_MAESTRO.DataSource = DV_MAESTRO;
            //'ENLAZO LOS TEXTBOX a combos	              
            this.txtcodigo.DataBindings.Add("text", BS_MAESTRO, "codigo",true);
            this.txtnombre.DataBindings.Add("text", BS_MAESTRO, "nombre", true);      
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
                else { cnt.Enabled = SioNo; }
            }
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
            DA_MAESTRO.InsertCommand = new MySqlCommand("add_tipoIDIBS", MyConex.MyConexion);
            DA_MAESTRO.InsertCommand.CommandType = CommandType.StoredProcedure;
            DA_MAESTRO.InsertCommand.Parameters.Add("pcodigo", MySqlDbType.VarChar, 4, "codigo");
            DA_MAESTRO.InsertCommand.Parameters.Add("pnombre", MySqlDbType.VarChar, 45, "nombre");          
            // UPDATE        
            DA_MAESTRO.UpdateCommand = new MySqlCommand("edit_tipoIDIBS", MyConex.MyConexion);
            DA_MAESTRO.UpdateCommand.CommandType = CommandType.StoredProcedure;
            DA_MAESTRO.UpdateCommand.Parameters.Add("pid", MySqlDbType.Int32, 10, "id");
            DA_MAESTRO.UpdateCommand.Parameters.Add("pcodigo", MySqlDbType.VarChar, 4, "codigo");
            DA_MAESTRO.UpdateCommand.Parameters.Add("pnombre", MySqlDbType.VarChar, 45, "nombre");
        }

        public override bool valido(TiposOperaciones operacion)
        {
            if (string.IsNullOrEmpty(txtcodigo.Text)) {
                MessageBox.Show("Debe especificar un código.", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (string.IsNullOrEmpty(txtcodigo.Text))
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

    }
}
