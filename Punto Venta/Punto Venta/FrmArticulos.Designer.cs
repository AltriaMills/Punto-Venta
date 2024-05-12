namespace Punto_de_venta
{
    partial class FrmArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticulos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbCambios = new System.Windows.Forms.GroupBox();
            this.lstCambios = new System.Windows.Forms.ListBox();
            this.bttnCambiosCancelar = new System.Windows.Forms.Button();
            this.txtCambiosPrecio = new System.Windows.Forms.TextBox();
            this.txtCambiosNombre = new System.Windows.Forms.TextBox();
            this.txtCambiosClave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bttnEditar = new System.Windows.Forms.Button();
            this.txtBuscarClave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.gpbBajas = new System.Windows.Forms.GroupBox();
            this.bttnBajasCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBajas = new System.Windows.Forms.TextBox();
            this.bttnBajas = new System.Windows.Forms.Button();
            this.gpbReportes = new System.Windows.Forms.GroupBox();
            this.lstBoxReportes = new System.Windows.Forms.ListBox();
            this.bttnRepCancelar = new System.Windows.Forms.Button();
            this.gpbRegistro = new System.Windows.Forms.GroupBox();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCLave = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.gpbCambios.SuspendLayout();
            this.gpbBajas.SuspendLayout();
            this.gpbReportes.SuspendLayout();
            this.gpbRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.cambiosToolStripMenuItem,
            this.bajasToolStripMenuItem});
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.articulosToolStripMenuItem.Text = "Articulos";
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.altasToolStripMenuItem.Text = "Altas";
            this.altasToolStripMenuItem.Click += new System.EventHandler(this.altasToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // cambiosToolStripMenuItem
            // 
            this.cambiosToolStripMenuItem.Name = "cambiosToolStripMenuItem";
            this.cambiosToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.cambiosToolStripMenuItem.Text = "Cambios";
            this.cambiosToolStripMenuItem.Click += new System.EventHandler(this.cambiosToolStripMenuItem_Click);
            // 
            // bajasToolStripMenuItem
            // 
            this.bajasToolStripMenuItem.Name = "bajasToolStripMenuItem";
            this.bajasToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.bajasToolStripMenuItem.Text = "Bajas";
            this.bajasToolStripMenuItem.Click += new System.EventHandler(this.bajasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.salirToolStripMenuItem.Text = "Da Vinci-Chan!!";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // gpbCambios
            // 
            this.gpbCambios.Controls.Add(this.lstCambios);
            this.gpbCambios.Controls.Add(this.bttnCambiosCancelar);
            this.gpbCambios.Controls.Add(this.txtCambiosPrecio);
            this.gpbCambios.Controls.Add(this.txtCambiosNombre);
            this.gpbCambios.Controls.Add(this.txtCambiosClave);
            this.gpbCambios.Controls.Add(this.label8);
            this.gpbCambios.Controls.Add(this.label7);
            this.gpbCambios.Controls.Add(this.label6);
            this.gpbCambios.Controls.Add(this.bttnEditar);
            this.gpbCambios.Controls.Add(this.txtBuscarClave);
            this.gpbCambios.Controls.Add(this.label4);
            this.gpbCambios.Controls.Add(this.bttnBuscar);
            this.gpbCambios.Location = new System.Drawing.Point(392, 42);
            this.gpbCambios.Name = "gpbCambios";
            this.gpbCambios.Size = new System.Drawing.Size(404, 251);
            this.gpbCambios.TabIndex = 4;
            this.gpbCambios.TabStop = false;
            this.gpbCambios.Text = "Cambios";
            // 
            // lstCambios
            // 
            this.lstCambios.FormattingEnabled = true;
            this.lstCambios.Location = new System.Drawing.Point(15, 59);
            this.lstCambios.Name = "lstCambios";
            this.lstCambios.Size = new System.Drawing.Size(286, 82);
            this.lstCambios.TabIndex = 18;
            // 
            // bttnCambiosCancelar
            // 
            this.bttnCambiosCancelar.Location = new System.Drawing.Point(202, 174);
            this.bttnCambiosCancelar.Name = "bttnCambiosCancelar";
            this.bttnCambiosCancelar.Size = new System.Drawing.Size(75, 23);
            this.bttnCambiosCancelar.TabIndex = 17;
            this.bttnCambiosCancelar.Text = "Cancelar";
            this.bttnCambiosCancelar.UseVisualStyleBackColor = true;
            this.bttnCambiosCancelar.Click += new System.EventHandler(this.bttnCambiosCancelar_Click);
            // 
            // txtCambiosPrecio
            // 
            this.txtCambiosPrecio.Location = new System.Drawing.Point(86, 199);
            this.txtCambiosPrecio.Name = "txtCambiosPrecio";
            this.txtCambiosPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtCambiosPrecio.TabIndex = 15;
            // 
            // txtCambiosNombre
            // 
            this.txtCambiosNombre.Location = new System.Drawing.Point(86, 174);
            this.txtCambiosNombre.Name = "txtCambiosNombre";
            this.txtCambiosNombre.Size = new System.Drawing.Size(100, 20);
            this.txtCambiosNombre.TabIndex = 14;
            // 
            // txtCambiosClave
            // 
            this.txtCambiosClave.Location = new System.Drawing.Point(86, 148);
            this.txtCambiosClave.Name = "txtCambiosClave";
            this.txtCambiosClave.Size = new System.Drawing.Size(100, 20);
            this.txtCambiosClave.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Clave";
            // 
            // bttnEditar
            // 
            this.bttnEditar.Location = new System.Drawing.Point(202, 145);
            this.bttnEditar.Name = "bttnEditar";
            this.bttnEditar.Size = new System.Drawing.Size(75, 23);
            this.bttnEditar.TabIndex = 12;
            this.bttnEditar.Text = "Editar";
            this.bttnEditar.UseVisualStyleBackColor = true;
            this.bttnEditar.Click += new System.EventHandler(this.bttnEditar_Click);
            // 
            // txtBuscarClave
            // 
            this.txtBuscarClave.Location = new System.Drawing.Point(56, 22);
            this.txtBuscarClave.Name = "txtBuscarClave";
            this.txtBuscarClave.Size = new System.Drawing.Size(120, 20);
            this.txtBuscarClave.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Clave";
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.Location = new System.Drawing.Point(182, 22);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttnBuscar.TabIndex = 7;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.UseVisualStyleBackColor = true;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // gpbBajas
            // 
            this.gpbBajas.Controls.Add(this.bttnBajasCancelar);
            this.gpbBajas.Controls.Add(this.label5);
            this.gpbBajas.Controls.Add(this.txtBajas);
            this.gpbBajas.Controls.Add(this.bttnBajas);
            this.gpbBajas.Location = new System.Drawing.Point(447, 318);
            this.gpbBajas.Name = "gpbBajas";
            this.gpbBajas.Size = new System.Drawing.Size(246, 151);
            this.gpbBajas.TabIndex = 5;
            this.gpbBajas.TabStop = false;
            this.gpbBajas.Text = "Bajas";
            // 
            // bttnBajasCancelar
            // 
            this.bttnBajasCancelar.Location = new System.Drawing.Point(89, 85);
            this.bttnBajasCancelar.Name = "bttnBajasCancelar";
            this.bttnBajasCancelar.Size = new System.Drawing.Size(75, 23);
            this.bttnBajasCancelar.TabIndex = 12;
            this.bttnBajasCancelar.Text = "Cancelar";
            this.bttnBajasCancelar.UseVisualStyleBackColor = true;
            this.bttnBajasCancelar.Click += new System.EventHandler(this.bttnBajasCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Clave";
            // 
            // txtBajas
            // 
            this.txtBajas.Location = new System.Drawing.Point(89, 23);
            this.txtBajas.Name = "txtBajas";
            this.txtBajas.Size = new System.Drawing.Size(141, 20);
            this.txtBajas.TabIndex = 9;
            // 
            // bttnBajas
            // 
            this.bttnBajas.Location = new System.Drawing.Point(89, 53);
            this.bttnBajas.Name = "bttnBajas";
            this.bttnBajas.Size = new System.Drawing.Size(77, 24);
            this.bttnBajas.TabIndex = 8;
            this.bttnBajas.Text = "Dar de Baja";
            this.bttnBajas.UseVisualStyleBackColor = true;
            this.bttnBajas.Click += new System.EventHandler(this.bttnBajas_Click);
            // 
            // gpbReportes
            // 
            this.gpbReportes.Controls.Add(this.lstBoxReportes);
            this.gpbReportes.Controls.Add(this.bttnRepCancelar);
            this.gpbReportes.Location = new System.Drawing.Point(12, 277);
            this.gpbReportes.Name = "gpbReportes";
            this.gpbReportes.Size = new System.Drawing.Size(349, 192);
            this.gpbReportes.TabIndex = 6;
            this.gpbReportes.TabStop = false;
            this.gpbReportes.Text = "Reportes";
            // 
            // lstBoxReportes
            // 
            this.lstBoxReportes.FormattingEnabled = true;
            this.lstBoxReportes.Location = new System.Drawing.Point(22, 26);
            this.lstBoxReportes.Name = "lstBoxReportes";
            this.lstBoxReportes.Size = new System.Drawing.Size(293, 108);
            this.lstBoxReportes.TabIndex = 7;
            // 
            // bttnRepCancelar
            // 
            this.bttnRepCancelar.Location = new System.Drawing.Point(22, 143);
            this.bttnRepCancelar.Name = "bttnRepCancelar";
            this.bttnRepCancelar.Size = new System.Drawing.Size(82, 32);
            this.bttnRepCancelar.TabIndex = 6;
            this.bttnRepCancelar.Text = "Cancelar";
            this.bttnRepCancelar.UseVisualStyleBackColor = true;
            this.bttnRepCancelar.Click += new System.EventHandler(this.bttnRepCancelar_Click);
            // 
            // gpbRegistro
            // 
            this.gpbRegistro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbRegistro.Controls.Add(this.bttnCancelar);
            this.gpbRegistro.Controls.Add(this.bttnGuardar);
            this.gpbRegistro.Controls.Add(this.txtPrecio);
            this.gpbRegistro.Controls.Add(this.txtNombre);
            this.gpbRegistro.Controls.Add(this.label3);
            this.gpbRegistro.Controls.Add(this.label2);
            this.gpbRegistro.Controls.Add(this.label1);
            this.gpbRegistro.Controls.Add(this.txtCLave);
            this.gpbRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRegistro.Location = new System.Drawing.Point(34, 59);
            this.gpbRegistro.Name = "gpbRegistro";
            this.gpbRegistro.Size = new System.Drawing.Size(286, 203);
            this.gpbRegistro.TabIndex = 7;
            this.gpbRegistro.TabStop = false;
            this.gpbRegistro.Text = "Registro";
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Location = new System.Drawing.Point(82, 157);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(80, 27);
            this.bttnCancelar.TabIndex = 8;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.Location = new System.Drawing.Point(82, 127);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(80, 24);
            this.bttnGuardar.TabIndex = 6;
            this.bttnGuardar.Text = "Guardar";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(82, 91);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clave";
            // 
            // txtCLave
            // 
            this.txtCLave.Location = new System.Drawing.Point(82, 26);
            this.txtCLave.Name = "txtCLave";
            this.txtCLave.Size = new System.Drawing.Size(100, 22);
            this.txtCLave.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(881, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 508);
            this.Controls.Add(this.gpbRegistro);
            this.Controls.Add(this.gpbReportes);
            this.Controls.Add(this.gpbBajas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gpbCambios);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmArticulos";
            this.Text = "FrmArticulos";
            this.Load += new System.EventHandler(this.FrmArticulos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbCambios.ResumeLayout(false);
            this.gpbCambios.PerformLayout();
            this.gpbBajas.ResumeLayout(false);
            this.gpbBajas.PerformLayout();
            this.gpbReportes.ResumeLayout(false);
            this.gpbRegistro.ResumeLayout(false);
            this.gpbRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpbCambios;
        private System.Windows.Forms.GroupBox gpbBajas;
        private System.Windows.Forms.GroupBox gpbReportes;
        private System.Windows.Forms.GroupBox gpbRegistro;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.Button bttnBajas;
        private System.Windows.Forms.Button bttnRepCancelar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCLave;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.ListBox lstBoxReportes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.TextBox txtBuscarClave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttnEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBajas;
        private System.Windows.Forms.TextBox txtCambiosPrecio;
        private System.Windows.Forms.TextBox txtCambiosNombre;
        private System.Windows.Forms.TextBox txtCambiosClave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnCambiosCancelar;
        private System.Windows.Forms.Button bttnBajasCancelar;
        private System.Windows.Forms.ListBox lstCambios;
    }
}