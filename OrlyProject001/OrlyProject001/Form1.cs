using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrlyProject001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ttotal_Click(object sender, EventArgs e)
        {

        }
        //T short
        // Pans
        

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }


        private void Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            type.Items.Clear();
            switch (category.SelectedIndex)
            {
                case 0:
                    type.Items.Add("Black");
                    type.Items.Add("White");
                    break;

                case 1:
                    type.Items.Add("Black");
                    type.Items.Add("White");
                    break;


            }
        }

    }
}
