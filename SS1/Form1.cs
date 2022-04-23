using SS1.Clases;

namespace SS1
{
    public partial class Form1 : Form
    {
        carro carrito;
        public Form1(carro _temporal)
        {
            InitializeComponent();
            //carrito = new carro("toyota", 2022, 100, "Juan Chapin");
            carrito = _temporal;
            labelDatos.Text = $"Marca: {carrito.Marca}, Propietario: {carrito.owner}";

        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            labelAcelerar.Text = carrito.acelerar();
        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            labelEncender.Text = carrito.EncenderMotor();
        }

    }
}