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
    public partial class frmSeleccionar : Form
    {
    

	private enum controlConstructor
	{
		combo,
		textbox
	}
	CapaConexion.Conexion con = new CapaConexion.Conexion();
	private ComboBox cmbBox;
	private TextBox txtBox;
	private DataTable Dt;
	private BindingSource Bs = new BindingSource();
	private string colunaDevolver;
	private List<string> titulosColumnas = new List<string>();

	private controlConstructor tipoControl;



	public void enlazarDatos(string[,] columnas, int seleccionado)
	{
		this.Bs.DataSource = Dt;
		this.dgvGrillaDatos.AutoGenerateColumns = false;
		this.dgvGrillaDatos.DataSource = Bs;
		cmbCriterio.SelectedIndex = 0;
		for (int i = 0; i <= columnas.GetUpperBound(0); i++) {
			string col = columnas[i, 0];
			string nombre = columnas[i, 1];
			titulosColumnas.Add(col);
			cmbCampo.Items.Add(nombre);
			System.Windows.Forms.DataGridViewTextBoxColumn colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			colum.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
			colum.DataPropertyName = col;
			colum.HeaderText = nombre;
			colum.Name = col;
			this.dgvGrillaDatos.Columns.Add(colum);
			colum.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
		}
		cmbCampo.SelectedIndex = 0;
		cmbCampo.SelectedIndex = seleccionado;
	}


	public frmSeleccionar(string procedimiento, ref ComboBox cmbPadre, string[,] columnas)
	{
		Load += frmSeleccionar_Load;
		InitializeComponent();
		//CARGAMOS LOS DATOS
		Dt = con.DevolverDatos(procedimiento);
		//   ENLAZAMOS LOS DATOS A LA GRILLA E INICIALIZAMOS 
		enlazarDatos(columnas, 1);
		// EDITAMOS SSEGUN EL TIPO (COMBO O TEXTBOX)
		tipoControl = controlConstructor.combo;
		cmbBox = cmbPadre;

	}
	public frmSeleccionar(string procedimiento, ref ComboBox cmbPadre, string[,] columnas, int seleccionado )
	{
		Load += frmSeleccionar_Load;
		InitializeComponent();
		//CARGAMOS LOS DATOS
		Dt = con.DevolverDatos(procedimiento);
		//   ENLAZAMOS LOS DATOS A LA GRILLA E INICIALIZAMOS 
		enlazarDatos(columnas, seleccionado);
		// EDITAMOS SSEGUN EL TIPO (COMBO O TEXTBOX)
		tipoControl = controlConstructor.combo;
		cmbBox = cmbPadre;

	}
	public frmSeleccionar(string procedimiento, ref ComboBox cmbPadre, string[,] columnas, string filtro, object valor, int seleccionado)
	{
		Load += frmSeleccionar_Load;
		InitializeComponent();
		//CARGAMOS LOS DATOS
		Dt = con.DevolverDatos(procedimiento, filtro, valor);
		//   ENLAZAMOS LOS DATOS A LA GRILLA E INICIALIZAMOS 
		enlazarDatos(columnas, seleccionado);
		// EDITAMOS SSEGUN EL TIPO (COMBO O TEXTBOX)
		tipoControl = controlConstructor.combo;
		cmbBox = cmbPadre;
	}
    public frmSeleccionar(string procedimiento, ref ComboBox cmbPadre, string[,] columnas, string filtro, object valor)
	{
		Load += frmSeleccionar_Load;
		InitializeComponent();
		//CARGAMOS LOS DATOS
		Dt = con.DevolverDatos(procedimiento, filtro, valor);
		//   ENLAZAMOS LOS DATOS A LA GRILLA E INICIALIZAMOS 
		enlazarDatos(columnas, 1);
		// EDITAMOS SSEGUN EL TIPO (COMBO O TEXTBOX)
		tipoControl = controlConstructor.combo;
		cmbBox = cmbPadre;
	}
	public frmSeleccionar(string procedimiento, ref ComboBox cmbPadre, string[,] columnas, string[] filtros, object[] valores, int seleccionado)
	{
		Load += frmSeleccionar_Load;
		InitializeComponent();
		//CARGAMOS LOS DATOS
		Dt = con.DevolverDatos(procedimiento, filtros, valores);
		//   ENLAZAMOS LOS DATOS A LA GRILLA E INICIALIZAMOS 
		enlazarDatos(columnas, seleccionado);
		// EDITAMOS SSEGUN EL TIPO (COMBO O TEXTBOX)
		tipoControl = controlConstructor.combo;
		cmbBox = cmbPadre;
	}
    public frmSeleccionar(string procedimiento, ref ComboBox cmbPadre, string[,] columnas, string[] filtros, object[] valores)
	{
		Load += frmSeleccionar_Load;
		InitializeComponent();
		//CARGAMOS LOS DATOS
		Dt = con.DevolverDatos(procedimiento, filtros, valores);
		//   ENLAZAMOS LOS DATOS A LA GRILLA E INICIALIZAMOS 
		enlazarDatos(columnas, 1);
		// EDITAMOS SSEGUN EL TIPO (COMBO O TEXTBOX)
		tipoControl = controlConstructor.combo;
		cmbBox = cmbPadre;
	}
	public frmSeleccionar(string procedimiento, TextBox txtBoxpadre, string[,] columnas, string colunaDevolucion, string filtro, object valor, int seleccionado )
	{
		Load += frmSeleccionar_Load;
		InitializeComponent();
		//CARGAMOS LOS DATOS
		Dt = con.DevolverDatos(procedimiento, filtro, valor);
		//   ENLAZAMOS LOS DATOS A LA GRILLA E INICIALIZAMOS 
		enlazarDatos(columnas, seleccionado);
		// EDITAMOS SSEGUN EL TIPO (COMBO O TEXTBOX)
		tipoControl = controlConstructor.textbox;
		txtBox = txtBoxpadre;
		colunaDevolver = colunaDevolucion;

	}
	public frmSeleccionar(string procedimiento, TextBox txtBoxpadre, string[,] columnas, string colunaDevolucion, string filtro, object valor)
	{
		Load += frmSeleccionar_Load;
		InitializeComponent();
		//CARGAMOS LOS DATOS
		Dt = con.DevolverDatos(procedimiento, filtro, valor);
		//   ENLAZAMOS LOS DATOS A LA GRILLA E INICIALIZAMOS 
		enlazarDatos(columnas, 1);
		// EDITAMOS SSEGUN EL TIPO (COMBO O TEXTBOX)
		tipoControl = controlConstructor.textbox;
		txtBox = txtBoxpadre;
		colunaDevolver = colunaDevolucion;

	}
	public frmSeleccionar(string procedimiento, TextBox txtBoxpadre, string[,] columnas, string colunaDevolucion, string[] filtros, object[] valores, int seleccionado )
	{
		Load += frmSeleccionar_Load;
		InitializeComponent();
		//CARGAMOS LOS DATOS
		Dt = con.DevolverDatos(procedimiento, filtros, valores);
		//   ENLAZAMOS LOS DATOS A LA GRILLA E INICIALIZAMOS 
		enlazarDatos(columnas, seleccionado);
		// EDITAMOS SSEGUN EL TIPO (COMBO O TEXTBOX)
		tipoControl = controlConstructor.textbox;
		txtBox = txtBoxpadre;
		colunaDevolver = colunaDevolucion;

	}
	public frmSeleccionar(string procedimiento, TextBox txtBoxpadre, string[,] columnas, string colunaDevolucion)
	{
		Load += frmSeleccionar_Load;
		InitializeComponent();
		//CARGAMOS LOS DATOS
		Dt = con.DevolverDatos(procedimiento);
		//   ENLAZAMOS LOS DATOS A LA GRILLA E INICIALIZAMOS 
		enlazarDatos(columnas,0);
		// EDITAMOS SSEGUN EL TIPO (COMBO O TEXTBOX)
		tipoControl = controlConstructor.textbox;
		txtBox = txtBoxpadre;
		colunaDevolver = colunaDevolucion;
	}
	public frmSeleccionar(string procedimiento, string filtro, string valor, ref ComboBox cmbPadre, string[,] columnas, int seleccionado )
	{
		Load += frmSeleccionar_Load;
		InitializeComponent();
		//CARGAMOS LOS DATOS
		Dt = con.DevolverDatos(procedimiento, filtro, valor);
		//   ENLAZAMOS LOS DATOS A LA GRILLA E INICIALIZAMOS 
		enlazarDatos(columnas, seleccionado);
		// EDITAMOS SSEGUN EL TIPO (COMBO O TEXTBOX)
		tipoControl = controlConstructor.combo;
		cmbBox = cmbPadre;

	}
    public frmSeleccionar(string procedimiento, string filtro, string valor, ref ComboBox cmbPadre, string[,] columnas)
	{
		Load += frmSeleccionar_Load;
		InitializeComponent();
		//CARGAMOS LOS DATOS
		Dt = con.DevolverDatos(procedimiento, filtro, valor);
		//   ENLAZAMOS LOS DATOS A LA GRILLA E INICIALIZAMOS 
		enlazarDatos(columnas, 1);
		// EDITAMOS SSEGUN EL TIPO (COMBO O TEXTBOX)
		tipoControl = controlConstructor.combo;
		cmbBox = cmbPadre;

	}
	public frmSeleccionar(string procedimiento, string filtro, string valor, TextBox txtBoxpadre, string[,] columnas, string colunaDevolucion, int seleccionado )
	{
		Load += frmSeleccionar_Load;
		InitializeComponent();
		//CARGAMOS LOS DATOS
		Dt = con.DevolverDatos(procedimiento, filtro, valor);
		//   ENLAZAMOS LOS DATOS A LA GRILLA E INICIALIZAMOS 
		enlazarDatos(columnas, seleccionado);
		// EDITAMOS SSEGUN EL TIPO (COMBO O TEXTBOX)
		tipoControl = controlConstructor.textbox;
		txtBox = txtBoxpadre;
		colunaDevolver = colunaDevolucion;
	}
    public frmSeleccionar(string procedimiento, string filtro, string valor, TextBox txtBoxpadre, string[,] columnas, string colunaDevolucion)
    {
        Load += frmSeleccionar_Load;
        InitializeComponent();
        //CARGAMOS LOS DATOS
        Dt = con.DevolverDatos(procedimiento, filtro, valor);
        //   ENLAZAMOS LOS DATOS A LA GRILLA E INICIALIZAMOS 
        enlazarDatos(columnas, 1);
        // EDITAMOS SSEGUN EL TIPO (COMBO O TEXTBOX)
        tipoControl = controlConstructor.textbox;
        txtBox = txtBoxpadre;
        colunaDevolver = colunaDevolucion;
    }
	private void frmSeleccionar_Load(System.Object sender, System.EventArgs e)
	{
		txtFiltro.Select();
		txtFiltro.Focus();
		int j = 0;
		for (j = 0; j <= dgvGrillaDatos.Columns.Count - 1; j++) {
			// dgvGrillaDatos.Columns.Item(j).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
		}
		txtFiltro.Select();
		txtFiltro.Focus();
		dgvGrillaDatos.Visible = true;

	}
	public void filtrar()
	{
		Bs.Filter = "";
		try {
			//CONTIENE
			if (cmbCriterio.SelectedIndex == 0) {
				try {
					// Bs.Filter = "CONVERT(" & titulosColumnas(cmbCampo.SelectedIndex) & ", 'System.String')  like '%" & txtFiltro.Text & "%'"
					Bs.Filter = CapaConexion.Funciones.devolverfiltrado(titulosColumnas[cmbCampo.SelectedIndex], txtFiltro.Text);
				} catch {
					if (txtFiltro.Text.Trim().Length>0) {
						MessageBox.Show("Seleccione el criterio de igualdad para este campo","SERFINANSA::.",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					}
				}

			} else if (cmbCriterio.SelectedIndex == 1) {
				try {
					Bs.Filter = "CONVERT(" + titulosColumnas[cmbCampo.SelectedIndex] + ", 'System.String')  like '" + txtFiltro.Text + "%'";
				//    Bs.Filter = FuncionesInternas.devolverfiltrado(titulosColumnas(cmbCampo.SelectedIndex), txtFiltro.Text)
				} catch {
					if (txtFiltro.Text.Trim().Length>0) {
                        MessageBox.Show("Seleccione el criterio de igualdad para este campo", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);						
					}
				}
			} else if (cmbCriterio.SelectedIndex == 2) {
				if (!(txtFiltro.Text == string.Empty)) {
					Bs.Filter = titulosColumnas[cmbCampo.SelectedIndex] + " = '" + txtFiltro.Text + "'";
				} else {
					Bs.Filter = "";
				}

			} else {
                MessageBox.Show("Seleccione el criterio de filtrado.", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				
			}
		} catch (Exception ex) {
            MessageBox.Show(ex.Message, "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				
		}
	}
    private void txtFiltro_TextChanged(object sender, EventArgs e)
    {
        if (titulosColumnas.Count > 0)
        {
            filtrar();
        }
    }
	private void cmbCampo_SelectedIndexChanged(System.Object sender, System.EventArgs e)
	{
		if (titulosColumnas.Count>0) {
			filtrar();
		}
	}

	private void dgvGrillaDatos_KeyUp(System.Object sender, System.Windows.Forms.KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Enter) {
			dgvGrillaDatos.CurrentRow.Selected = true;
			e.Handled = true;
			seleccionar();
		}

	}

	public void seleccionar()
	{
		if (dgvGrillaDatos.SelectedRows.Count>0) {
			if (tipoControl == controlConstructor.combo) {
				cmbBox.SelectedValue = ( ((DataRow)Bs.Current)["id"]).ToString();
				//    Me.dgvGrillaDatos.SelectedRows(0).Cells("ID").Value
			} else if (tipoControl == controlConstructor.textbox) {
                txtBox.Text = (((DataRowView)Bs.Current)[colunaDevolver]).ToString(); 
				// Me.dgvGrillaDatos.SelectedRows(0).Cells(colunaDevolver).Value
			}
			Close();
		} else {
            MessageBox.Show("Debe seleccionar una fila en la grilla", "SERFINANSA::.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);				
		}
	}

    private void dgvGrillaDatos_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Enter) {
			e.Handled = true;
			e.SuppressKeyPress = true;
		}
	}
	private void dgvGrillaDatos_CellMouseDoubleClick(System.Object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
	{
		//btnSeleccionar_Click(Nothing, Nothing)
		seleccionar();
	}


	private void btnSeleccionar_Click(System.Object sender, System.EventArgs e)
	{
		seleccionar();
	}

	private void cmbCriterio_SelectedIndexChanged(System.Object sender, System.EventArgs e)
	{
		filtrar();
	}

	
    private void btnCancelar_Click(object sender, EventArgs e)
    {
        Close();
    }



  
   


 


    }
}
