using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Listas
{
    public partial class frmCargarOfac : Form
    {
        private BindingList<IbsStructurePlana> listaOFAC = new BindingList<IbsStructurePlana>();
        private BindingSource bs = new BindingSource();
        private DateTime ultimaPublicacion, dtPublicacionFile;
     
        #region "CONSTRUCTOR Y LOAD DEL FORM"
        public frmCargarOfac()
        {
            InitializeComponent();
            txtRuta.Text = Listas.Properties.Settings.Default.urlOfac;
            gridDatos.AutoGenerateColumns = false;
            bs.DataSource = listaOFAC;
            gridDatos.DataSource = bs;
        }
      
        private void frmCargarOfac_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            ultimaPublicacion = Funciones.getLastChargedList("OFAC");
            lblFechaPublicacion.Text = ultimaPublicacion.ToShortDateString();
            fnProcesando(false);
        }
     #endregion

        #region "BOTONES"
        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                dtPublicacionFile = Funciones.readOFACPublish_Date(txtRuta.Text.Trim());

                if (dtPublicacionFile <= this.ultimaPublicacion)
                {
                   MessageBox.Show("No puede subir este archivo pues la fecha de publicación es posterior o igual  a la ultima registrada en el sistema", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   return ;
               }
               listaOFAC = new BindingList<IbsStructurePlana>(Funciones.converToPlain(Funciones.readOFACList(txtRuta.Text.Trim())));
               lblCantidad.Text =listaOFAC.Count.ToString();
               lblFechaArchivo.Text = dtPublicacionFile.ToShortDateString();
               fnProcesando(true);
               bs.DataSource = listaOFAC;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"SERFINANSA::.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
     
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Funciones.saveList(listaOFAC.ToList(), dtPublicacionFile, "OFAC"))
                {
                    MessageBox.Show("La lista ofac ha sido procesada satisfacrtoriamente!!.", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ultimaPublicacion = dtPublicacionFile;
                    lblFechaPublicacion.Text = ultimaPublicacion.ToShortDateString();
                    fnProcesando(false);

                    
                    SaveFileDialog sd = new SaveFileDialog();
                    sd.FileName = "OFAC" + dtPublicacionFile.Year + dtPublicacionFile.Month.ToString().PadLeft(2, '0') + dtPublicacionFile.Day.ToString().PadLeft(2, '0');                
                    DialogResult result=  sd.ShowDialog();
                    if (result!= DialogResult.OK)
                    {
                        MessageBox.Show("La lista fue guardada, pero el archivo plano no fue generado.", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    List<string> Fuente = new List<string>();
                    Fuente.Add("OFAC");
                    Funciones.generateFile(sd.FileName, Fuente);
                    MessageBox.Show("El archivo plano fue generado.", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmResumenLista frmResumen = new frmResumenLista("OFAC");
                    frmResumen.ShowDialog(this);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fnProcesando(false);
        }
        #endregion
     
        #region "OTRAS FUNCIONES"
        private void fnProcesando(Boolean boolean) {
            if (!boolean)
            {
                listaOFAC.Clear();
                btnCargar.Enabled = true;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                lblCantidad.Text = "0";
                lblFechaArchivo.Text = "--/--/----";                
            }
            else {
                btnCargar.Enabled = false;
                btnCancelar.Enabled = true;
                btnGuardar.Enabled = true;
            }
        }
        #endregion
    }
}
