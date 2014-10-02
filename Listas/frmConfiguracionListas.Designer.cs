namespace Listas
{
    partial class frmConfiguracionListas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracionListas));
            this.pnlDown = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tlpContenedor = new System.Windows.Forms.TableLayoutPanel();
            this.txtOfac = new System.Windows.Forms.TextBox();
            this.txtOnu = new System.Windows.Forms.TextBox();
            this.gbConfiguracionListas = new System.Windows.Forms.GroupBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlDown.SuspendLayout();
            this.tlpContenedor.SuspendLayout();
            this.gbConfiguracionListas.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDown
            // 
            this.pnlDown.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlDown.Controls.Add(this.btnAceptar);
            this.pnlDown.Controls.Add(this.btnCancelar);
            this.pnlDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDown.Location = new System.Drawing.Point(0, 86);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDown.Size = new System.Drawing.Size(376, 52);
            this.pnlDown.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAceptar.Image = global::Listas.Properties.Resources.redo_icon;
            this.btnAceptar.Location = new System.Drawing.Point(191, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 42);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Image = global::Listas.Properties.Resources.close_icon;
            this.btnCancelar.Location = new System.Drawing.Point(281, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 42);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "OFAC:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "ONU:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpContenedor
            // 
            this.tlpContenedor.ColumnCount = 2;
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContenedor.Controls.Add(this.label1, 0, 0);
            this.tlpContenedor.Controls.Add(this.label2, 0, 1);
            this.tlpContenedor.Controls.Add(this.txtOfac, 1, 0);
            this.tlpContenedor.Controls.Add(this.txtOnu, 1, 1);
            this.tlpContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenedor.Location = new System.Drawing.Point(3, 16);
            this.tlpContenedor.Name = "tlpContenedor";
            this.tlpContenedor.RowCount = 3;
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContenedor.Size = new System.Drawing.Size(360, 57);
            this.tlpContenedor.TabIndex = 3;
            // 
            // txtOfac
            // 
            this.txtOfac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOfac.Location = new System.Drawing.Point(47, 3);
            this.txtOfac.Name = "txtOfac";
            this.txtOfac.Size = new System.Drawing.Size(310, 20);
            this.txtOfac.TabIndex = 3;
            // 
            // txtOnu
            // 
            this.txtOnu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOnu.Location = new System.Drawing.Point(47, 29);
            this.txtOnu.Name = "txtOnu";
            this.txtOnu.Size = new System.Drawing.Size(310, 20);
            this.txtOnu.TabIndex = 4;
            // 
            // gbConfiguracionListas
            // 
            this.gbConfiguracionListas.Controls.Add(this.tlpContenedor);
            this.gbConfiguracionListas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbConfiguracionListas.Location = new System.Drawing.Point(5, 5);
            this.gbConfiguracionListas.Name = "gbConfiguracionListas";
            this.gbConfiguracionListas.Size = new System.Drawing.Size(366, 76);
            this.gbConfiguracionListas.TabIndex = 4;
            this.gbConfiguracionListas.TabStop = false;
            this.gbConfiguracionListas.Text = "Origen de las listas";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.gbConfiguracionListas);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Padding = new System.Windows.Forms.Padding(5);
            this.pnlContenedor.Size = new System.Drawing.Size(376, 86);
            this.pnlContenedor.TabIndex = 5;
            // 
            // frmConfiguracionListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 138);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfiguracionListas";
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            this.pnlDown.ResumeLayout(false);
            this.tlpContenedor.ResumeLayout(false);
            this.tlpContenedor.PerformLayout();
            this.gbConfiguracionListas.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tlpContenedor;
        private System.Windows.Forms.TextBox txtOfac;
        private System.Windows.Forms.TextBox txtOnu;
        private System.Windows.Forms.GroupBox gbConfiguracionListas;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}