using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_media2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btCalculo_Click(object sender, EventArgs e)
        {
            double media, n1 = 0, n2 = 0, n3 = 0;



            /*
             media = ((Convert.ToDouble(tbNota1.Text) + 
                          Convert.ToDouble(tbNota2.Text) + 
                          Convert.ToDouble(tbNota3.Text)) / 3);
            */
            
            if (tbNota1.Text != "")
            {
                n1 = Convert.ToDouble(tbNota1.Text);
            }
            
            if (tbNota2.Text != "")
            {
                n2 = Convert.ToDouble(tbNota2.Text);
            }

            if (tbNota3.Text != "")
            {
                n3 = Convert.ToDouble(tbNota3.Text);
            }
            /*
            n1 = Convert.ToDouble(tbNota1.Text);
            n2 = Convert.ToDouble(tbNota2.Text);
            n3 = Convert.ToDouble(tbNota3.Text);
            */
            media = (n1 + n2 + n3) / 3;
            tbMedia.Text = Convert.ToString(media);

            if (media < 5)
            {
                MessageBox.Show("Reprovado", "tchau");
            }
            else if (media < 7)
            {
                MessageBox.Show("Recuperação", "opa");
            }
            else
                MessageBox.Show("Aprovado!!!");



        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbNota1.Text = "";
            tbNota2.Text = "";
            tbNota3.Text = "";
            tbMedia.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
