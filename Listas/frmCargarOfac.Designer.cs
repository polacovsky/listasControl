namespace Listas
{
    partial class frmCargarOfac
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
            this.pnlDown = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFechaPublicacion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblEtiquetaCantidad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCausal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaArchivo = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlDown.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDown.Controls.Add(this.btnGuardar);
            this.pnlDown.Controls.Add(this.btnCancelar);
            this.pnlDown.Controls.Add(this.label5);
            this.pnlDown.Controls.Add(this.lblFechaPublicacion);
            this.pnlDown.Controls.Add(this.label4);
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(0, 358);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDown.Size = new System.Drawing.Size(865, 52);
            this.pnlDown.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Image = global::Listas.Properties.Resources.cancel_icon;
            this.btnCancelar.Location = new System.Drawing.Point(768, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 40);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // lblFechaPublicacion
            // 
            this.lblFechaPublicacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFechaPublicacion.Location = new System.Drawing.Point(77, 5);
            this.lblFechaPublicacion.Name = "lblFechaPublicacion";
            this.lblFechaPublicacion.Size = new System.Drawing.Size(102, 40);
            this.lblFechaPublicacion.TabIndex = 12;
            this.lblFechaPublicacion.Text = "--/--/----";
            this.lblFechaPublicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 40);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ultima Lista:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(130, 9);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(13, 13);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "0";
            // 
            // lblEtiquetaCantidad
            // 
            this.lblEtiquetaCantidad.AutoSize = true;
            this.lblEtiquetaCantidad.Location = new System.Drawing.Point(4, 9);
            this.lblEtiquetaCantidad.Name = "lblEtiquetaCantidad";
            this.lblEtiquetaCantidad.Size = new System.Drawing.Size(120, 13);
            this.lblEtiquetaCantidad.TabIndex = 10;
            this.lblEtiquetaCantidad.Text = "Cantidad De Individuos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRuta);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 49);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ubicacion Origen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ruta o URL:";
            // 
            // txtRuta
            // 
            this.txtRuta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRuta.Location = new System.Drawing.Point(79, 20);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(306, 20);
            this.txtRuta.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(865, 59);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.panel2.Size = new System.Drawing.Size(865, 299);
            this.panel2.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridDatos);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(5, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 294);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cargada";
            // 
            // gridDatos
            // 
            this.gridDatos.AllowUserToAddRows = false;
            this.gridDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDatos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colTipoPersona,
            this.colNumID,
            this.colTipoID,
            this.colNombreC,
            this.colNombres,
            this.colApellidos,
            this.colCausal});
            this.gridDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDatos.Location = new System.Drawing.Point(3, 52);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.ReadOnly = true;
            this.gridDatos.Size = new System.Drawing.Size(849, 239);
            this.gridDatos.TabIndex = 13;
            // 
            // colCodigo
            // 
            this.colCodigo.DataPropertyName = "codigo";
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 80;
            // 
            // colTipoPersona
            // 
            this.colTipoPersona.DataPropertyName = "tipopersona";
            this.colTipoPersona.HeaderText = "TipoPersona";
            this.colTipoPersona.Name = "colTipoPersona";
            this.colTipoPersona.ReadOnly = true;
            // 
            // colNumID
            // 
            this.colNumID.DataPropertyName = "numid";
            this.colNumID.HeaderText = "Num ID";
            this.colNumID.Name = "colNumID";
            this.colNumID.ReadOnly = true;
            // 
            // colTipoID
            // 
            this.colTipoID.DataPropertyName = "tipoid";
            this.colTipoID.HeaderText = "Tipo ID";
            this.colTipoID.Name = "colTipoID";
            this.colTipoID.ReadOnly = true;
            // 
            // colNombreC
            // 
            this.colNombreC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombreC.DataPropertyName = "nombrecompleto";
            this.colNombreC.HeaderText = "Nombre Completo";
            this.colNombreC.Name = "colNombreC";
            this.colNombreC.ReadOnly = true;
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
            // colCausal
            // 
            this.colCausal.DataPropertyName = "causal";
            this.colCausal.HeaderText = "Cod. Causal";
            this.colCausal.Name = "colCausal";
            this.colCausal.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblFechaArchivo);
            this.panel3.Controls.Add(this.lblEtiquetaCantidad);
            this.panel3.Controls.Add(this.lblCantidad);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 36);
            this.panel3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha Publicacion:";
            // 
            // lblFechaArchivo
            // 
            this.lblFechaArchivo.AutoSize = true;
            this.lblFechaArchivo.Location = new System.Drawing.Point(340, 9);
            this.lblFechaArchivo.Name = "lblFechaArchivo";
            this.lblFechaArchivo.Size = new System.Drawing.Size(41, 13);
            this.lblFechaArchivo.TabIndex = 13;
            this.lblFechaArchivo.Text = "--/--/----";
            // 
            // btnCargar
            // 
            this.btnCargar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCargar.Image = global::Listas.Properties.Resources.export_icon;
            this.btnCargar.Location = new System.Drawing.Point(391, 16);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(94, 30);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar ";
            this.btnCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.Image = global::Listas.Properties.Resources.save_accept;
            this.btnGuardar.Location = new System.Drawing.Point(678, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 40);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmCargarOfac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 410);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDown);
            this.Name = "frmCargarOfac";
            this.Text = "Cargar Lista Ofac";
            this.Load += new System.EventHandler(this.frmCargarOfac_Load);
            this.pnlDown.ResumeLayout(false);
            this.pnlDown.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblEtiquetaCantidad;
        private System.Windows.Forms.Label lblFechaPublicacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaArchivo;
        private System.Windows.Forms.DataGridView gridDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCausal;
        private System.Windows.Forms.Label label4;

    }
}