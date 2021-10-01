using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void brVerificar_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;

            peso = Convert.ToDouble(textBox1.Text);
            altura = Convert.ToDouble(tbAltura.Text);
            
            imc = peso / (altura * altura) ;


            textBox2.Text = imc.ToString("0.00");

            if (imc < 18.49)
                MessageBox.Show("Abaixo do peso");
            else if (imc < 24.99)
                MessageBox.Show("Peso Normal");
            else if (imc < 29.99)
                MessageBox.Show("Acima do peso", "Pesado",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc <34.99)
                MessageBox.Show("Obesidade I", "Pesado",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 39.99)
                MessageBox.Show("Obesidade II", "Pesado",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Obesidade III", "Pesadasso",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);







        }
    }
}
