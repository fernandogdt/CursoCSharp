using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banco_Dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btnConectar_Click(object sender, EventArgs e)
        {

            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.CST;

            try
            {
                
                con.Open();

                SqlCommand Cmm = new SqlCommand();
                Cmm.CommandText = "SELECT * FROM tb_clientes";
                Cmm.CommandType = CommandType.Text;
                Cmm.Connection = con;
                
                SqlDataReader DR;
                DR = Cmm.ExecuteReader();

                
                DataTable dt = new DataTable();
                dt.Load(DR);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();


                con.Close();

                MessageBox.Show("A conexão foi realizada com Sucesso!", "ok");
          
          
            }
            catch (Exception exc)
            {
                MessageBox.Show(String.Format("Falha na Conexão:{0}", exc.Message));
            }
        }
    }
}
