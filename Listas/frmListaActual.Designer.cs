namespace Listas
{
    partial class frmListaActual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.colFuente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltipoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcausal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldireccion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldireccion3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfechaInclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.pnlDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(943, 64);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFiltrar.Image = global::Listas.Properties.Resources.redo_icon;
            this.btnFiltrar.Location = new System.Drawing.Point(200, 16);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(84, 35);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "TODAS",
            "OFAC",
            "ONU"});
            this.comboBox1.Location = new System.Drawing.Point(57, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fuente:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridDatos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(943, 268);
            this.panel1.TabIndex = 5;
            // 
            // gridDatos
            // 
            this.gridDatos.AllowUserToAddRows = false;
            this.gridDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDatos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFuente,
            this.colCodigo,
            this.colTipoPersona,
            this.coltipoID,
            this.colnumID,
            this.colcausal,
            this.colnombreCompleto,
            this.colNombres,
            this.colApellidos,
            this.colPais,
            this.coldepartamento,
            this.coldireccion1,
            this.direccion2,
            this.coldireccion3,
            this.colfechaNacimiento,
            this.colfechaInclusion});
            this.gridDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDatos.Location = new System.Drawing.Point(5, 5);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.ReadOnly = true;
            this.gridDatos.Size = new System.Drawing.Size(933, 258);
            this.gridDatos.TabIndex = 6;
            // 
            // colFuente
            // 
            this.colFuente.DataPropertyName = "fuente";
            this.colFuente.HeaderText = "Fuente";
            this.colFuente.Name = "colFuente";
            this.colFuente.ReadOnly = true;
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "codigo";
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colTipoPersona
            // 
            this.colTipoPersona.DataPropertyName = "tipoPersona";
            this.colTipoPersona.HeaderText = "Tipo";
            this.colTipoPersona.Name = "colTipoPersona";
            this.colTipoPersona.ReadOnly = true;
            this.colTipoPersona.Width = 60;
            // 
            // coltipoID
            // 
            this.coltipoID.DataPropertyName = "tipoID";
            this.coltipoID.HeaderText = "Tipo ID";
            this.coltipoID.Name = "coltipoID";
            this.coltipoID.ReadOnly = true;
            this.coltipoID.Width = 130;
            // 
            // colnumID
            // 
            this.colnumID.DataPropertyName = "numID";
            this.colnumID.HeaderText = "Identificacion";
            this.colnumID.Name = "colnumID";
            this.colnumID.ReadOnly = true;
            // 
            // colcausal
            // 
            this.colcausal.DataPropertyName = "causal";
            this.colcausal.HeaderText = "Causal";
            this.colcausal.Name = "colcausal";
            this.colcausal.ReadOnly = true;
            this.colcausal.Width = 160;
            // 
            // colnombreCompleto
            // 
            this.colnombreCompleto.DataPropertyName = "nombreCompleto";
            this.colnombreCompleto.HeaderText = "Nmbre . Completo";
            this.colnombreCompleto.Name = "colnombreCompleto";
            this.colnombreCompleto.ReadOnly = true;
            this.colnombreCompleto.Width = 180;
            // 
            // colNombres
            // 
            this.colNombres.DataPropertyName = "nombres";
            this.colNombres.HeaderText = "Nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.ReadOnly = true;
            // 
            // colApellidos
            // 
            this.colApellidos.DataPropertyName = "apellidos";
            this.colApellidos.HeaderText = "Apellidos";
            this.colApellidos.Name = "colApellidos";
            this.colApellidos.ReadOnly = true;
            // 
            // colPais
            // 
            this.colPais.DataPropertyName = "pais";
            this.colPais.HeaderText = "Pais";
            this.colPais.Name = "colPais";
            this.colPais.ReadOnly = true;
            // 
            // coldepartamento
            // 
            this.coldepartamento.DataPropertyName = "departamento";
            this.coldepartamento.HeaderText = "Departamento";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.ReadOnly = true;
            // 
            // coldireccion1
            // 
            this.coldireccion1.DataPropertyName = "direccion1";
            this.coldireccion1.HeaderText = "Dir 1";
            this.coldireccion1.Name = "coldireccion1";
            this.coldireccion1.ReadOnly = true;
            // 
            // direccion2
            // 
            this.direccion2.DataPropertyName = "direccion2";
            this.direccion2.HeaderText = "Dir 2";
            this.direccion2.Name = "direccion2";
            this.direccion2.ReadOnly = true;
            // 
            // coldireccion3
            // 
            this.coldireccion3.DataPropertyName = "direccion3";
            this.coldireccion3.HeaderText = "Dir 3";
            this.coldireccion3.Name = "coldireccion3";
            this.coldireccion3.ReadOnly = true;
            // 
            // colfechaNacimiento
            // 
            this.colfechaNacimiento.DataPropertyName = "fechaNacimiento";
            dataGridViewCellStyle2.Format = "d";
            this.colfechaNacimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.colfechaNacimiento.HeaderText = "Nacimiento/Constitucion";
            this.colfechaNacimiento.Name = "colfechaNacimiento";
            this.colfechaNacimiento.ReadOnly = true;
            // 
            // colfechaInclusion
            // 
            this.colfechaInclusion.DataPropertyName = "fechaInclusion";
            dataGridViewCellStyle3.Format = "d";
            this.colfechaInclusion.DefaultCellStyle = dataGridViewCellStyle3;
            this.colfechaInclusion.HeaderText = "Inclusion ";
            this.colfechaInclusion.Name = "colfechaInclusion";
            this.colfechaInclusion.ReadOnly = true;
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDown.Controls.Add(this.label3);
            this.pnlDown.Controls.Add(this.label2);
            this.pnlDown.Controls.Add(this.btnExportar);
            this.pnlDown.Controls.Add(this.btnCerrar);
            this.pnlDown.Controls.Add(this.label5);
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(0, 332);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDown.Size = new System.Drawing.Size(943, 52);
            this.pnlDown.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Registros:";
            // 
            // btnExportar
            // 
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExportar.Image = global::Listas.Properties.Resources.export_icon;
            this.btnExportar.Location = new System.Drawing.Point(756, 5);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(90, 40);
            this.btnExportar.TabIndex = 8;
            this.btnExportar.TabStop = false;
            this.btnExportar.Text = "&Exportar";
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Image = global::Listas.Properties.Resources.close_icon;
            this.btnCerrar.Location = new System.Drawing.Point(846, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 40);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Puerto:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmListaActual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDown);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListaActual";
            this.Text = "Lista De Control Actual";
            this.Load += new System.EventHandler(this.frmListaActual_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.pnlDown.ResumeLayout(false);
            this.pnlDown.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFuente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltipoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcausal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldireccion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldireccion3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfechaInclusion;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}