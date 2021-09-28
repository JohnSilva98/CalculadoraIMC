using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPeso_Click(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularIMC_Click(object sender, EventArgs e)
        {
            //declaração de variavéis e atribuição as textBoxes
            double altura, peso, imc;
            altura = double.Parse(txtAltura.Text);
            peso = double.Parse(txtPeso.Text);
            imc = peso / (altura * altura);
            //estrutura condicional para testar o valor do IMC e mostrar o resultado

            if (imc < 18.5)
            {
                txtIMC.Text = imc.ToString("F");
                txtResultIMC.Text = "Abaixo do peso ideal";
            }else if(imc >=18.5 && imc <= 24.9)
            {
                txtIMC.Text = imc.ToString("F");
                txtResultIMC.Text = "Peso ideal";
            }else if(imc>=25.0 && imc <= 29.9)
            {
                txtIMC.Text = imc.ToString("F");
                txtResultIMC.Text = "Levemente acima do peso";
            }else if(imc>=30.0 && imc <= 34.9)
            {
                txtIMC.Text = imc.ToString("F");
                txtResultIMC.Text = "Obesidade grau I";
            }else if(imc >=35.0 && imc <= 39.9){
                txtIMC.Text = imc.ToString("F");
                txtResultIMC.Text = "Obesidade grau II (Severa)";
            }
            else
            {
                txtIMC.Text = imc.ToString("F");
                txtResultIMC.Text = "Obesidade grau III (Mórbida)";
            }
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            txtPeso.Text = "";
            txtAltura.Text = "";
            txtResultIMC.Text = "";
            txtIMC.Text = "";

        }

        private void txtIMC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
