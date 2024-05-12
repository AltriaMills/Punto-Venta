using Punto_Venta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta
{

    public partial class FrmArticulos : Form
    {
        public int indiceActual = 0;
        public PV[] ArregloArticulos = new PV[150];
        public class PV
        {
            public String Clave;
            public String Nombre;
            public double Precio;
            public PV(String Clave, String Nombre, double Precio)
            {
                this.Clave = Clave;
                this.Nombre = Nombre;
                this.Precio = Precio;
            }
        };

        private double textToDouble(String T1)
        {
            double s = 0;
            try
            {
                s = Convert.ToDouble(T1);
            }
            catch
            {
            }
            return s;
        }

        private bool existClave(PV[] ArregloArticulos, int iArticulo, String clave)
        {
            bool decision = false;
            for (int j = 0; j < iArticulo; j++)
            {
                if (ArregloArticulos[j].Clave == clave)
                {
                    decision = true;
                    break;
                }
            }
            return decision;
        }


        public FrmArticulos()
        {
            InitializeComponent();
            gpbRegistro.Visible = false;
            gpbCambios.Visible = false;
            gpbBajas.Visible = false;
            gpbReportes.Visible = false;
        }


        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbRegistro.Visible = false;
            gpbCambios.Visible = false;
            gpbBajas.Visible = false;
            gpbReportes.Visible = false;
            gpbRegistro.Location = new Point(455, 139);
            txtCLave.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCLave.Focus();
            gpbRegistro.Visible = true;
        }

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            String Clave = this.txtCLave.Text;
            if (existClave(ArregloArticulos, indiceActual, Clave))
            {
                MessageBox.Show("La clave ingresada ya existe, favor de ingresar otra", "Error");
            }
            else
            {
                //Console.WriteLine(Clave);
                String Nombre = this.txtNombre.Text;
                //Console.WriteLine(Nombre);
                double Precio = textToDouble(this.txtPrecio.Text);
                if (Precio <= 0)
                {
                    MessageBox.Show("El precio debe de ser una variable en decimal mayor a 0", "Error");
                }
                else
                {
                    PV nuevoArticulo = new PV(Clave, Nombre, Precio); // Definimos un nuevo objeto llamado nuevoempleado. de tipo de la clase PV y le estamos inicializando con valores por defecto
                    ArregloArticulos[indiceActual] = nuevoArticulo;
                    indiceActual++;
                    MessageBox.Show("Articulo dado de Alta exitosamente", "Alta Satisfactoria");
                }
            }

        }
        private void putlboxArticulo(PV nuevoArticulo)
        {
            String Clave = nuevoArticulo.Clave;
            String Nombre = nuevoArticulo.Nombre;
            double Precio = nuevoArticulo.Precio;
            this.lstBoxReportes.Items.Add(Clave + " " + Nombre + " " + Precio + " ");
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {

        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            gpbRegistro.Visible = false;
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbReportes.Visible = true;
            gpbRegistro.Visible = false;
            gpbCambios.Visible = false;
            gpbBajas.Visible = false;
            gpbReportes.Location = new Point(430, 266);
            lstBoxReportes.Items.Clear();
            for (int i = 0; i < indiceActual; i++)
            {
                PV articuloActual = ArregloArticulos[i];
                putlboxArticulo(articuloActual);
            }
        }
        
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Punto_Venta.Salir salida = new Salir();
            salida.Show();
            //Application.Exit();
        }


        private void cambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbCambios.Visible = true;
            gpbReportes.Visible = false;
            gpbRegistro.Visible = false;
            gpbBajas.Visible = false;
            gpbCambios.Location = new Point(452, 57);
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            String clave = this.txtBuscarClave.Text;
            int i = buscarArticulo(clave);
            if (i == -1)
            {
                MessageBox.Show("no hay coincidencias", ":(");
            }
            else
            {
                //this.pnlCambiosEdicion.Visible = true;
                this.txtCambiosClave.Text = ArregloArticulos[i].Clave;
                this.txtCambiosNombre.Text = ArregloArticulos[i].Nombre;
                this.txtCambiosPrecio.Text = Convert.ToString(ArregloArticulos[i].Precio);
            }
        }

        private int buscarArticulo(String clave)
        {
            int i = -1;
            for (int j = 0; j < indiceActual; j++)
            {
                //bool encontrado = ArregloArticulos[j].Clave.Contains(clave);
                bool encontrado = ArregloArticulos[j].Clave.Equals(clave);
                if (encontrado)
                {
                    i = j;
                    break;
                }
            }
            return i;
        }

        private void bttnEditar_Click(object sender, EventArgs e)
        {
            String clave = this.txtBuscarClave.Text;
            double precio = textToDouble(txtCambiosPrecio.Text);
            if (precio <= 0)
            {
                MessageBox.Show("El precio debe de ser una variable en decimal mayor a 0", "Error");
            }
            else
            {
                int i = buscarArticulo(clave);
                this.ArregloArticulos[i].Clave = txtCambiosClave.Text;
                this.ArregloArticulos[i].Nombre = txtCambiosNombre.Text;
                this.ArregloArticulos[i].Precio = precio;
                MessageBox.Show("Los cambios han sido realizados, para ver los cambios vuelve a buscar el articulo", ";)");
              
            }
        }

        private void bajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbBajas.Visible = true;
            gpbReportes.Visible = false;
            gpbRegistro.Visible = false;
            gpbCambios.Visible = false;
            gpbBajas.Location = new Point(452, 57);
        }

        private void bttnBajas_Click(object sender, EventArgs e)
        {
            String clave = this.txtBajas.Text;
            int i = buscarArticulo(clave);
            if (i == -1)
            {
                MessageBox.Show("La clave ingresada no fue encontrada", "Error");
            }
            else
            {
                for (int j = i + 1; j < indiceActual; j++)
                {
                    ArregloArticulos[j - 1] = ArregloArticulos[j];
                }
                indiceActual--;
                MessageBox.Show("Clave dada de baja exitosamente", "Baja exitosa");
            }
        }

        private void bttnCambiosCancelar_Click(object sender, EventArgs e)
        {
            gpbCambios.Visible=false;
        }

        private void bttnBajasCancelar_Click(object sender, EventArgs e)
        {
            gpbBajas.Visible=false;
            gpbReportes.Visible=!false;
        }

        private void bttnRepCancelar_Click(object sender, EventArgs e)
        {
            gpbReportes.Visible=false;
           reportesToolStripMenuItem.Visible=false;
            
        }

    }
}




