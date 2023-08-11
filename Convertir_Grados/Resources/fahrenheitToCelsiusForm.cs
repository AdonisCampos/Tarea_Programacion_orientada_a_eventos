using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertir_Grados.Resources
{
    public partial class fahrenheitToCelsiusForm : Form
    {
        public fahrenheitToCelsiusForm()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtFahrenheit.Text, out double fahrenheit))
            {
                // Realizar la conversión de grados Fahrenheit a grados Celsius
                double celsius = (fahrenheit - 32) * 5 / 9;

                // Mostrar el resultado en el label
                lblResultado.Text = "La temperatura en grados Celsius es: " + celsius.ToString("0.00") + " °C";
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido para los grados Fahrenheit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
