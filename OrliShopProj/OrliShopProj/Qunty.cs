using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrliShopProj
{
    public partial class Qunty : Form
    {
        public static string v;
        public Qunty()
        {
            InitializeComponent();
        }

        private void Qunty_Load(object sender, EventArgs e)
        {

            this.Text = "כמות הפריטים";

        }

        private void Disable_Click(object sender, EventArgs e)
        {
            Form1.flag = 0;
            Close();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            //Form1.flag = 1;
            //if (Form1.a > 0 )
            //{
            try
            {
                Form1.a = int.Parse(textBox1.Text);
                Form1.flag = 1;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(": הכנס מספר");
            }
            //}
            //else if (Form1.a == 0 || Form1.a == null)
            //{
            //    MessageBox.Show("הכנס כמות");
            //}

            Form1.b += (Form1.price1 * Form1.a);
            Form1.b1 = Form1.price1 * Form1.a;
            Form1.n2 = Form1.a + "*" + Form1.price1 + "=" + Form1.b1.ToString();

            Form1.f1 = 1;
            if (Form1.a != 0)
            Form1.rem += "\n" + Form1.a + "*" + Form1.price1 + "=" + Form1.b1.ToString();


            if(Form1.a!=0)
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
