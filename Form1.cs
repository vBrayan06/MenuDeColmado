namespace MenuDeColmado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            double precio = 0;

            if (cmbProductos.Text == "Habichuelas Rojas (1 lb) - $65") precio = 65;
            else if (cmbProductos.Text == "Aceite de Soya (16 oz) - $85") precio = 85;
            else if (cmbProductos.Text == "Queso Amarillo (1 lb) - $180") precio = 180;
            else if (cmbProductos.Text == "Huevos (Unidad) - $8") precio = 8;
            else if (cmbProductos.Text == "Azúcar Blanca (1 lb) - $30") precio = 30;
            else if (cmbProductos.Text == "Café Molido (Sobre) - $25") precio = 25;
            else if (cmbProductos.Text == "Leche Evaporada (Lata) - $60") precio = 60;

            double total = precio * cantidad;

            string metodo = "";
            if (rdoEfectivo.Checked) metodo = "Efectivo";
            else if (rdoTarjeta.Checked) metodo = "Tarjeta";
            else if (rdoTransferencia.Checked) metodo = "Transferencia";

            lblTotal.Text = "Total a pagar: RD$ " + total + " (" + metodo + ")";
        }
    }
}