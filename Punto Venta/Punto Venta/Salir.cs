﻿using System;
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
    public partial class Salir : Form
    {
        public Salir()
        {
            InitializeComponent();
        }

        private void Salir_Load(object sender, EventArgs e)
        {

        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se hace responsable!", "MASTER:");
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblDaVinciChan_Click(object sender, EventArgs e)
        {

        }
    }
}
