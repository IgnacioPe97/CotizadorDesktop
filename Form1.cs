using Billetes;
using System.ComponentModel;

namespace CotizadorDesktop
{
    public partial class Form1 : Form
    {

        Dolar dolares;
        Euro euros;

        public Form1()
        {
            InitializeComponent();

        }

        private void tb_euroCotizacion_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(this.tb_euroCotizacion.Text, out int numDoc);
            Euro.SetCotizacion(numDoc);
        }

        private void tb_dolarCotizacion_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(this.tb_dolarCotizacion.Text, out int numDoc);
            dolares = new Dolar(numDoc);
        }

        private void tb_PesoCotizacion_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(this.tb_PesoCotizacion.Text, out int numDoc);
        }
        private void button_Candado_Click(object sender, EventArgs e)
        {
            bool estadoBoton;

            if (true)
            {
                tb_euroCotizacion.Enabled = false; // deshabilito el textbox para escribir
                tb_PesoCotizacion.Enabled = false;
                tb_dolarCotizacion.Enabled = false;
                estadoBoton = false;

            }
            else
            {
                tb_euroCotizacion.Enabled = true; // Habilito textbox para escribir
                tb_PesoCotizacion.Enabled = true;
                tb_dolarCotizacion.Enabled = true;
                estadoBoton = false;
            }

        }

        private void tb_EuroCantidad_TextChanged(object sender, EventArgs e)
        {
           

            /*
            double cantidadEuros;
                if (double.TryParse(tb_EuroCantidad.Text, out cantidadEuros))
            {
                Euro nuevoEuro = new Euro(cantidadEuros);
                tb_EuroAEuro.Text = Convert.ToString(nuevoEuro.GetCantidad());
                Dolar dolar = (Dolar)nuevoEuro;
                TB_EuroADolar.Text = Convert.ToString(nuevoEuro.GetCantidad());
                Peso peso = (Peso)nuevoEuro;
                tb_EuroAPeso.Text= Convert.ToString(nuevoEuro.GetCantidad());
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_euroCotizacion.Text = Convert.ToString(Euro.GetCotizacion());
            tb_PesoCotizacion.Text = Convert.ToString(Peso.GetCotizacion());
            tb_dolarCotizacion.Text = Convert.ToString(Dolar.GetCotizacion());

        }

        private void tb_EuroCantidad_Validating(object? sender, CancelEventArgs e)
        {
            double num;
            if (!double.TryParse(tb_EuroCantidad.Text, out num))
            {
                MessageBox.Show("Debe ingresar un valor numérico.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_EuroCantidad.Focus();
                e.Cancel = true;
            }
        }// valida que sea solo numeros txt_Euro

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*Este codigo permite que se cierre la ventana del windows form sin que se llene */
            tb_EuroCantidad.Validating -= tb_EuroCantidad_Validating;
            tb_DolarCantidad.Validating -= tb_DolarCantidad_Validating;
            tb_PesoCantidad.Validating -= tb_PesoCantidad_Validating;

        }
        private void tb_DolarCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_DolarCantidad_Validating(object?/*el signo permite que sea NULL*/ sender, CancelEventArgs e)
        {
            double num;
            if (!double.TryParse(this.tb_DolarCantidad.Text, out num))
            {
                MessageBox.Show("Debe ingresar un valor numérico.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_EuroCantidad.Focus();
                e.Cancel = true;
            }

        }// valida que sea solo numeros txt_Dolar

        private void tb_PesoCantidad_Validating(object? sender, CancelEventArgs e)
        {
            double num;
            if (!double.TryParse(tb_PesoCantidad.Text, out num))
            {
                MessageBox.Show("Debe ingresar un valor numérico.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_EuroCantidad.Focus();
                e.Cancel = true;
            }
        } // valida que sea solo numeros txt_Peso

        private void button_Euro_Click(object sender, EventArgs e) // al apretar click en el boton de conversion euros 
        {
            double vuelto;
            double.TryParse(this.tb_PesoCantidad.Text, out vuelto); // tomo la cantidad ingresada en textbox de Euros
            Euro euros = new Euro(vuelto); //creo mi objeto EURO con la cantidad solicitada a convertir
            tb_EuroAEuro.Text = Convert.ToString(euros.GetCantidad()); // escribo en mi textbox de conversion EURO A EURO
            Dolar dolares = (Dolar)euros;//creo mi objeto EURO
            TB_EuroADolar.Text = Convert.ToString(dolares.GetCantidad());
            Peso peso = (Peso)euros;//creo mi objeto EURO
            tb_EuroAPeso.Text = Convert.ToString(peso.GetCantidad());
        }
    }
}