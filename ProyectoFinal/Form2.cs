using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form2 : Form
    {
        public Vestimentas Vestimentas { set; get; }
        public Form2()
        {
            InitializeComponent();
            Vestimentas = new Vestimentas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvVestimentas.DataSource = Vestimentas.Cadena(txtCadena.Text);
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvPreciodeVestimenta.DataSource = Vestimentas.PreciodeVestimenta();
        }
        private void limpiar()
        {
            txtCadena.Text = "";
        }
    }
}
