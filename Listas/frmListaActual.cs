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
    public partial class frmListaActual : Form
    {
        BindingSource bs = new BindingSource();
        BindingList<IbsStructurePlana> lista;

        public frmListaActual()
        {
            InitializeComponent();

            bs.DataSourceChanged += new  System.EventHandler (this.bs_ListChanged);
        }

        private void bs_ListChanged(object sender, EventArgs  e)
        {
            label3.Text = lista.Count().ToString(); 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmListaActual_Load(object sender, EventArgs e)
        {
           lista = new BindingList<IbsStructurePlana>(   Funciones.get_ListaActual());
           bs.DataSource = lista;
           gridDatos.AutoGenerateColumns = false;
           gridDatos.DataSource = bs;
           WindowState = FormWindowState.Maximized;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaConexion.Funciones.ExportGridToExcel(gridDatos);
            }
            catch (Exception)
            {                
                throw;
            }            
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() != "TODAS")
            {
               lista = new BindingList<IbsStructurePlana>(Funciones.get_ListaActual().Where(obj => obj.fuente.Equals(comboBox1.SelectedItem.ToString())).ToList());
                bs.DataSource = lista;
            }
            else {
                lista = new BindingList<IbsStructurePlana>(Funciones.get_ListaActual());
                bs.DataSource = lista;
            }
        }

     

     
     
    }
}
