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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int contador;
            for (contador = 2016; contador>= 1950; contador--)
            {
               cbano.Items.Add(contador);
                
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            this.Visible = false;
            formulario.Visible = true;
        }
    }
}
