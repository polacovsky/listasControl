namespace App
{
    partial class frmConfigConexion
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
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.gbConfiguracionListas = new System.Windows.Forms.GroupBox();
            this.tlpContenedor = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaseDatos = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.pnlDown = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlContenedor.SuspendLayout();
            this.gbConfiguracionListas.SuspendLayout();
            this.tlpContenedor.SuspendLayout();
            this.pnlDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.gbConfiguracionListas);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Padding = new System.Windows.Forms.Padding(5);
            this.pnlContenedor.Size = new System.Drawing.Size(316, 113);
            this.pnlContenedor.TabIndex = 7;
            // 
            // gbConfiguracionListas
            // 
            this.gbConfiguracionListas.Controls.Add(this.tlpContenedor);
            this.gbConfiguracionListas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbConfiguracionListas.Location = new System.Drawing.Point(5, 5);
            this.gbConfiguracionListas.Name = "gbConfiguracionListas";
            this.gbConfiguracionListas.Size = new System.Drawing.Size(306, 103);
            this.gbConfiguracionListas.TabIndex = 4;
            this.gbConfiguracionListas.TabStop = false;
            this.gbConfiguracionListas.Text = "Origen de las listas";
            // 
            // tlpContenedor
            // 
            this.tlpContenedor.ColumnCount = 2;
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tlpContenedor.Controls.Add(this.label4, 0, 3);
            this.tlpContenedor.Controls.Add(this.label3, 0, 2);
            this.tlpContenedor.Controls.Add(this.label1, 0, 0);
            this.tlpContenedor.Controls.Add(this.txtBaseDatos, 1, 0);
            this.tlpContenedor.Controls.Add(this.txtServer, 1, 2);
            this.tlpContenedor.Controls.Add(this.txtPuerto, 1, 3);
            this.tlpContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenedor.Location = new System.Drawing.Point(3, 16);
            this.tlpContenedor.Name = "tlpContenedor";
            this.tlpContenedor.RowCount = 7;
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContenedor.Size = new System.Drawing.Size(300, 84);
            this.tlpContenedor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Puerto:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Servidor:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base Datos:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBaseDatos
            // 
            this.txtBaseDatos.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBaseDatos.Location = new System.Drawing.Point(74, 3);
            this.txtBaseDatos.Name = "txtBaseDatos";
            this.txtBaseDatos.Size = new System.Drawing.Size(222, 20);
            this.txtBaseDatos.TabIndex = 3;
            // 
            // txtServer
            // 
            this.txtServer.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtServer.Location = new System.Drawing.Point(74, 29);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(222, 20);
            this.txtServer.TabIndex = 6;
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(74, 55);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(222, 20);
            this.txtPuerto.TabIndex = 8;
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlDown.Controls.Add(this.btnAceptar);
            this.pnlDown.Controls.Add(this.btnCancelar);
            this.pnlDown.Controls.Add(this.label5);
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(0, 113);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDown.Size = new System.Drawing.Size(316, 40);
            this.pnlDown.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAceptar.Location = new System.Drawing.Point(161, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 30);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Location = new System.Drawing.Point(236, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
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
            // frmConfigConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 153);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmConfigConexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion Conexion Base Datos::.";
            this.Load += new System.EventHandler(this.frmConfigConexion_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.gbConfiguracionListas.ResumeLayout(false);
            this.tlpContenedor.ResumeLayout(false);
            this.tlpContenedor.PerformLayout();
            this.pnlDown.ResumeLayout(false);
            this.pnlDown.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.GroupBox gbConfiguracionListas;
        private System.Windows.Forms.TableLayoutPanel tlpContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaseDatos;
        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label5;
    }
}