using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BasicForms
{
    public partial class frmMaestroDesconectado : Form
    {
        public frmMaestroDesconectado()
        {
            InitializeComponent();
            BS_MAESTRO.PositionChanged += new System.EventHandler(this.POSICION);
        }
        private void frmMaestroDesconectado_Load(object sender, EventArgs e)
        {
            cargarDatos();
            construircomandos();
            editando(false);           
        }
        public CapaConexion.Conexion MyConex = new CapaConexion.Conexion();
        
        public enum TiposOperaciones
        {
            None = 1,
            Insert = 2,
            Update = 3
        }

        protected MySql.Data.MySqlClient.MySqlDataAdapter DA_MAESTRO = new MySqlDataAdapter();
        public BindingSource BS_MAESTRO= new BindingSource();
        public DataSet DS_MAESTRO = new DataSet();        
        public DataView DV_MAESTRO;
        public TiposOperaciones OperacionActual;

        #region "CONSTRUCTOR"
     

        private void frmMaestroEstandar_Load(System.Object sender, System.EventArgs e)
        {
            cargarDatos();
            construircomandos();
            editando(false);
        }
        #endregion

        //---------------OJO CON ESTO,ESTAS FUNCIONES DEBEN SER SOBREESCRITAS -----------------------'
        #region "FUNCIONES QUE DEBEN SER SOBREESCRITAS"

        public virtual void editando(bool SioNo)
        {
            //Throw New NotImplementedException()
        }
        public virtual void construircomandos()
        {
            // Throw New NotImplementedException()
        }
        public virtual void cargarDatos()
        {
            //  Throw New NotImplementedException()
        }

        public virtual bool valido(TiposOperaciones operacion)
        {
            // Throw New NotImplementedException()
            return false;
        }

        #endregion
        //**************--------------------------------------------************

        #region "ACTIVAR Y DESACTIVAR BARRA"

        public void DesactivarBarra()
        {
            btnFirst.Enabled = false;
            btnBack.Enabled = false;
            btnNext.Enabled = false;
            btnLast.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
            btnAceptar.Enabled = true;
            btnEliminar.Enabled = false;
        }

        public void ActivarBarra()
        {
            if (BS_MAESTRO.Count == 0)
            {
                btnEditar.Enabled = false;
            }
            else
            {
                btnEditar.Enabled = true;
            }
            btnFirst.Enabled = true;
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            btnLast.Enabled = true;
            btnNuevo.Enabled = true;
            btnCancelar.Enabled = false;
            btnAceptar.Enabled = false;
            btnEliminar.Enabled = true;
        }

        #endregion

        #region "BOTONES DE NAVEGACION"
        private void btnFirst_Click(System.Object sender, System.EventArgs e)
        {
            if (BS_MAESTRO.Position > 0)
            {
                BS_MAESTRO.MoveFirst();
            }
            else
            {
                MessageBox.Show("Ya se encuentra en el primer registro","SERFINANSA::.", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnBack_Click(System.Object sender, System.EventArgs e)
        {
            if (BS_MAESTRO.Position > 0)
            {
                BS_MAESTRO.MovePrevious();
            }
            else
            {
                MessageBox.Show("Ya se encuentra en el primer registro", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);           
            }
        }

        private void btnNext_Click(System.Object sender, System.EventArgs e)
        {
            if (BS_MAESTRO.Position < BS_MAESTRO.Count - 1)
            {
                BS_MAESTRO.MoveNext();
            }
            else
            {
                MessageBox.Show("Ya se encuentra en el último registro", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
            }
        }

        private void btnLast_Click(System.Object sender, System.EventArgs e)
        {
            if (BS_MAESTRO.Position < BS_MAESTRO.Count - 1)
            {
                BS_MAESTRO.MoveLast();
            }
            else
            {
                MessageBox.Show("Ya se encuentra en el último registro", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                                
            }
        }
        #endregion

        #region "ACTUALIZA ID EN DATASET AUTOMATICAMENTE"
        public virtual void OnRowUpdated(object Sender, MySql.Data.MySqlClient.MySqlRowUpdatedEventArgs  args)
        {
            if (args.StatementType == StatementType.Insert)
            {
                MySqlCommand cmd = new MySqlCommand("LAST_INSERT_ID()", args.Command.Connection);
                args.Row["ID"] = cmd.ExecuteScalar();
            }
        }
        #endregion

        #region "EVENTOS UPDATE E INSERT"
        public void AddRegistro()
        {
            OperacionActual = TiposOperaciones.Insert;
            BS_MAESTRO.EndEdit();
            BS_MAESTRO.AddNew();
            editando(true);

        }

        public void EditRegistro()
        {
            OperacionActual = TiposOperaciones.Update;
            BS_MAESTRO.EndEdit();
            editando(true);

        }

        public void AnularRegistro()
        {
            if (MessageBox.Show("Va a anular el registro\n¿Desea en realidad anularlo?", "SERFINANSA::.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    BS_MAESTRO.RemoveCurrent();
                    DA_MAESTRO.Update(DS_MAESTRO.Tables[0]);
                    DS_MAESTRO.AcceptChanges();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message, "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                                  
                    DS_MAESTRO.RejectChanges();
                }
            }
        }

        public void CancelEdit()
        {
            OperacionActual = TiposOperaciones.None;
            this.BS_MAESTRO.CancelEdit();
            DS_MAESTRO.RejectChanges();
            editando(false);

        }

        public void SaveEdit()
        {
            if (valido(OperacionActual))
            {

                try
                {
                    this.BS_MAESTRO.EndEdit();
                    DA_MAESTRO.Update(DS_MAESTRO.Tables[0]);
                    DS_MAESTRO.AcceptChanges();
                    editando(false);
                    MessageBox.Show("La operación se ejecuto satisfactoriamente", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Information);                                   
                
                }
                catch (Exception EX)
                {
                    MessageBox.Show("No se pudo ejecutar la operación."+EX.Message, "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                }
            }


        }
        #endregion

        #region "BOTONES DE OPERACIONES"
        public virtual void btnNew_Click(System.Object sender, System.EventArgs e)
        {
            AddRegistro();
        }
        public virtual void btnEdit_Click(System.Object sender, System.EventArgs e)
        {
            EditRegistro();
        }

        public virtual void btnAnular_Click(System.Object sender, System.EventArgs e)
        {
            AnularRegistro();
        }

        public virtual void btnCancel_Click(System.Object sender, System.EventArgs e)
        {
            CancelEdit();
        }
        public virtual void btnOk_Click(System.Object sender, System.EventArgs e)
        {
            SaveEdit();
        }
        #endregion

        #region "POSICION"
        public void POSICION(object sender, EventArgs e)
        {
            lblPosicion.Text =  + BS_MAESTRO.Position + 1 + " de " + BS_MAESTRO.Count;
        }
        #endregion

 
       
      

     

       

    }
}
