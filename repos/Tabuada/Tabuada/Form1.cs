using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 1, num;

            num = Convert.ToInt32(tbNumero.Text);

            while (x <= 10)
            {

                listBox1.Items.Add(num + " * " + x + " = " + x*num);
                x++;

            }


        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbNumero.Text = "";
            listBox1.Items.Clear();
        }
    }
}
