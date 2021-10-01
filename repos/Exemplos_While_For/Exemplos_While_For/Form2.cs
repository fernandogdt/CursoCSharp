using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplos_While_For
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int contador = 2021;

            do
            {

                comboBox1.Items.Add(contador);
                contador--;


            } while (contador >= 1983);
            
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Visible = true;
            this.Visible = false;
        }
    }
}
