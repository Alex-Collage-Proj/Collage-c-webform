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
    public partial class Form1 : Form
    {
        public static int flag = 0,f1=0;
        public static int a, b,b1, price1, price2;
        public static string n, n1, n2,rem;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            
            Tot.Enabled = true;
            Payment.Enabled = false;
        }

        private void Tot_Click(object sender, EventArgs e)
        {
            // Totcalc.Text = n2;
             Totcalc.Text = rem + "\n סה''כ:" + Form1.b.ToString() + "ש''ח";
            Tot.Enabled = false;
        }

        private void Disable_Click(object sender, EventArgs e)
        {
            price.Text = "מחיר";
            calc.Text = "חישוב לפי כמות";
            Totcalc.Text = "";
            flag = 0;
            Qnty.Enabled = false;
            Payment.Enabled = false;
            Tot.Enabled = false;
            Disable.Enabled = false;
            rem = "";
            Form1.b = 0;

        }


        private void Cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            switch (Cat.SelectedIndex)
            {
                case 0:
                    listBox1.Items.Add("שחור נייק");
                    listBox1.Items.Add("לבן אדידס");

                    //Qnty.Enabled = true;
                    //Disable.Enabled = true;

                    break;

                case 1:
                    listBox1.Items.Add(" נייק");
                    listBox1.Items.Add(" אדידס");
                    //Qnty.Enabled = true;
                    //Disable.Enabled = true;
                    break;
                case 2:
                    listBox1.Items.Add("שחור ");
                    listBox1.Items.Add("לבן ");
                    //Qnty.Enabled = true;
                    //Disable.Enabled = true;
                    break;
                case 3:
                    listBox1.Items.Add("וורד");
                    listBox1.Items.Add("סגול");
                    //Qnty.Enabled = true;
                    //Disable.Enabled = true;
                    break;

            }
        }


        private void Qnty_Click(object sender, EventArgs e)
        {

            calc.Text = n2;



            n1 = listBox1.Text;

            ////case 0
            if (Cat.SelectedIndex == 0)
            {
                if (n1 == "שחור נייק")
                {
                    n = "שחור נייק";
                }
                else
                {
                    n = "לבן אדידס";
                }


                if (n == "שחור נייק")
                {
                    price1 = 5;
                    price.Text = price1.ToString();
                }
                else
                {
                    price1 = 6;
                    price.Text = price1.ToString();
                }
            }
            ////////////////////////////////////////////////////////////////// case 1
            if (Cat.SelectedIndex == 1)
            {
                if (n1 == " נייק")
                {
                    n = " נייק";
                }
                else
                {
                    n = " אדידס";
                }


                if (n == " נייק")
                {
                    price1 = 3;
                    price.Text = price1.ToString();
                }
                else
                {
                    price1 = 4;
                    price.Text = price1.ToString();
                }
            }
            ////////////////////////////////////////////////////////////////// case 2
            if (Cat.SelectedIndex == 2)
            {
                if (n1 == "שחור ")
                {
                    n = "שחור ";
                }
                else
                {
                    n = "לבן ";
                }


                if (n == "שחור ")
                {
                    price1 = 8;
                    price.Text = price1.ToString();
                }
                else
                {
                    price1 = 2;
                    price.Text = price1.ToString();
                }
            }

            ////////////////////////////////////////////////////////////////// case 3
            if (Cat.SelectedIndex == 3)
            {
                if (n1 == "וורד")
                {
                    n = "וורד";
                }
                else
                {
                    n = "סגול";
                }


                if (n == "וורד")
                {
                    price1 = 10;
                    price.Text = price1.ToString();
                }
                else
                {
                    price1 = 15;
                    price.Text = price1.ToString();
                }
            }

            //////////////////////////////////////////////////////////////////////


            a = 0;
            Qunty f2 = new Qunty();
            f2.ShowDialog();
            if (flag == 1)
            {
                Payment.Enabled = true;
                Qnty.Enabled = false;
            }
            calc.Text = n2;
            Form1.flag = 1;





        }


        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }




        private void price_Click(object sender, EventArgs e)
        {

            //if (flag == 1)
            //{
            //    Payment.Enabled = true;
            //       calc.Text = n2;
            //    //    Totcalc.Text = Form1.b.ToString();
               
            //}

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Qnty.Enabled = true;
            Disable.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e) 
        {

            this.Text = "בחירת קטגוריה";
            
            


        }
    }
}
