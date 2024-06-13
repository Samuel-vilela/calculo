using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            string input = txtNumero.Text;
            double numero; 

            if (double.TryParse(input, out numero))
            {
                double quadrado = Math.Pow(numero, 2);
                lblResultado.Text = $" o quadrado de {numero} é {quadrado}";
            }
            else
            {
                lblResultado.Text = "Entrada invalida. por favor, digite um número";
            }
        }
    }
}
