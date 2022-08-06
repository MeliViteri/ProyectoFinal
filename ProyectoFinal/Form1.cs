using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        Vestimentas Vestimentas = new Vestimentas();
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Vestimenta vestimenta = new Vestimenta();
            vestimenta.Nombre = txtNombre.Text;
            vestimenta.Apellido = txtApellido.Text;
            vestimenta.Cedula = txtCedula.Text;
            vestimenta.TipodeVestimenta = cmbTipo.SelectedItem.ToString();
            vestimenta.ColordeVestimenta = txtColor.Text;
            vestimenta.MarcadeVestimenta = cmbMarca.SelectedItem.ToString();
            vestimenta.TipodeTela = cmbTela.SelectedItem.ToString();
            vestimenta.PreciodeVestimenta = Convert.ToInt32(mtxtPrecio.Text);
            Vestimentas.Agregar(vestimenta);
            MessageBox.Show("Datos ingresados");
            limpiar();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvVestimenta.DataSource = Vestimentas.Vestimentas1;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.Vestimentas = Vestimentas;
        }
        private void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCedula.Text = "";
            cmbTipo.Text = "";
            txtColor.Text = "";
            cmbMarca.Text = "";
            cmbTela.Text = "";
            mtxtPrecio.Text = "";

        }
    }
}
