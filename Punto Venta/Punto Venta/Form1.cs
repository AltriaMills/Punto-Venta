using Punto_de_venta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_Venta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false; 
            Punto_de_venta.FrmArticulos frmArticulo = new FrmArticulos();
            frmArticulo.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Salir salida = new Salir();
            salida.Show();
            //Application.Exit();
        }

        private void puntoVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDaVinci.Parent = pictureBox1;
            lblDaVinci.BackColor = Color.Transparent;
        }
    }
}
