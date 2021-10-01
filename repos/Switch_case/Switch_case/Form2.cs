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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            switch (cbPlacas.Text){

                case "1 ou 2":
                    lbResultado.Text = "Segunda";
                    break;
                case "3 ou 4":
                    lbResultado.Text = "Terca";
                    break;
                case "5 ou 6":
                    lbResultado.Text = "Quarta";
                    break;
                case "7 ou 8":
                    lbResultado.Text = "Quinta";
                    break;
                case "9 ou 0":
                    lbResultado.Text = "Sexta";
                    break;

            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Form novo = new Form1();
            novo.Show();
            this.Visible = false;
        }
    }
}
