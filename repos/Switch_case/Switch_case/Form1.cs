using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbSemana_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbSemana.Text)
            {
                case "Domingo":
                    MessageBox.Show("Dia 1");
                    break;
                case "Segunda":
                    MessageBox.Show("Dia 2");
                    break;
                case "Terça":
                    MessageBox.Show("Dia 3");
                    break;
                case "Quarta":
                    MessageBox.Show("Dia 4");
                    break;
                case "Quinta":
                    MessageBox.Show("Dia 5");
                    break;
                case "Sexta":
                    MessageBox.Show("Dia 6");
                    break;
                case "Sabado":
                    MessageBox.Show("Dia 7");
                    break;
            }


        }

        private void btProximo_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();
            this.Visible = false;
        }
    }
}
