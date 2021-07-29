using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orliproj
{

    public partial class Form1 : Form
    {
        private DataTable dt;
        int count;



       string conncetionST = @"data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alex\source\repos\orliproj\orliproj\Database2.mdf;Integrated Security=True";
     //  string conncatioSt = Properties.Settings.Default.Database2;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlCon = new SqlConnection(conncetionST);
            try
            {
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter("Select * From City", sqlCon);
                dt = new DataTable();
                sqlCon.Open();
                sqlDataAdap.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

        }
    }
}
