using SS1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS1
{
    public partial class FormInicio : Form
    {
        carro carr;
        public FormInicio()
        {
            InitializeComponent();
        }

        private void CrearCarro()
        {
            string mar = comboBoxMarcas.Text;
            int modelo = Convert.ToInt32(textBoxModelo.Text);
            int maxvel = Convert.ToInt32(textBoxMaxVel.Text);
            string owner = textBoxOwner.Text;

            carr = new carro(mar, modelo, maxvel, owner);

            Form1 otroFormulario = new Form1(carr);
            otroFormulario.Show();
        }
        private void buttonNewCar_Click(object sender, EventArgs e)
        {
            CrearCarro();

        }
    }
}
