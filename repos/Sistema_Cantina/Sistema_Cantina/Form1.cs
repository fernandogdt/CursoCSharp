using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Cantina
{
    public partial class Form1 : Form
    {

        string[] produtos = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        double soma;




        public Form1()
        {
            InitializeComponent();
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
            if (tbCodigo.Text.Length == 3)
            {

                int indice = 0;
                for (int i = 1; i < codigo.Length; i++)
                {
                    if (tbCodigo.Text == codigo[i])
                    {
                        indice = i;

                    }
                }
                if (indice == 0)
                {
                    MessageBox.Show("Produto não encontrado");
                }
                else
                {
                    lbCaixa.Items.Add(tbCodigo.Text + " " + produtos[indice] + " -- R$ " + 
                                        valor[indice]);

                    soma = soma + valor[indice];
                    label3.Text = "Valor Total R$ " + soma;
                    pbImagem.ImageLocation = "C:/Users/Elton Fernando/Pictures/1 (" + indice +
                        ").JPG";

                    tbCodigo.Text = "";
                    tbCodigo.Focus();

                }

                /*
                lbCaixa.Items.Add(tbCodigo.Text);
                tbCodigo.Text = "";
                tbCodigo.Focus();
                */
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregaArray();
            soma = 0;
            tbCodigo.Focus();
        }

        private void carregaArray()
        {
            codigo[1] = "001";
            codigo[2] = "002";
            codigo[3] = "003";
            codigo[4] = "004";
            codigo[5] = "005";

            produtos[1] = "Pastel";
            produtos[2] = "Coxinha";
            produtos[3] = "Hot Dog";
            produtos[4] = "Chocolate";
            produtos[5] = "Suco";

            valor[1] = 6;
            valor[2] = 5;
            valor[3] = 12.00;
            valor[4] = 3.5;
            valor[5] = 8.000;

        }

    }
}
