namespace Punto_Venta
{
    partial class Salir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salir));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnSalir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDaVinciChan = new System.Windows.Forms.Label();
            this.lblDialogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bttnSalir
            // 
            this.bttnSalir.BackColor = System.Drawing.Color.Peru;
            this.bttnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSalir.Location = new System.Drawing.Point(12, 12);
            this.bttnSalir.Name = "bttnSalir";
            this.bttnSalir.Size = new System.Drawing.Size(150, 46);
            this.bttnSalir.TabIndex = 2;
            this.bttnSalir.Text = "Nani?!";
            this.bttnSalir.UseVisualStyleBackColor = false;
            this.bttnSalir.Click += new System.EventHandler(this.bttnSalir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 339);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(531, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblDaVinciChan
            // 
            this.lblDaVinciChan.AutoSize = true;
            this.lblDaVinciChan.BackColor = System.Drawing.Color.Blue;
            this.lblDaVinciChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaVinciChan.ForeColor = System.Drawing.Color.White;
            this.lblDaVinciChan.Location = new System.Drawing.Point(63, 339);
            this.lblDaVinciChan.Name = "lblDaVinciChan";
            this.lblDaVinciChan.Size = new System.Drawing.Size(80, 24);
            this.lblDaVinciChan.TabIndex = 4;
            this.lblDaVinciChan.Text = "Da Vinci";
            this.lblDaVinciChan.Click += new System.EventHandler(this.lblDaVinciChan_Click);
            // 
            // lblDialogo
            // 
            this.lblDialogo.AutoSize = true;
            this.lblDialogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDialogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialogo.ForeColor = System.Drawing.Color.White;
            this.lblDialogo.Location = new System.Drawing.Point(208, 370);
            this.lblDialogo.Name = "lblDialogo";
            this.lblDialogo.Size = new System.Drawing.Size(248, 37);
            this.lblDialogo.TabIndex = 5;
            this.lblDialogo.Text = "Me voy a casa!!!";
            // 
            // Salir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 427);
            this.Controls.Add(this.lblDialogo);
            this.Controls.Add(this.lblDaVinciChan);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bttnSalir);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Salir";
            this.Text = "Salir";
            this.Load += new System.EventHandler(this.Salir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttnSalir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDaVinciChan;
        private System.Windows.Forms.Label lblDialogo;
    }
}