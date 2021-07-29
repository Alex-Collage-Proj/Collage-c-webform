using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moveeee
{
    public partial class Form1 : Form
    {
        enum Position
        {
            Left, Right, Up, Down ,Stop
        }
        private int x;
        private int y;
        private int w;
        private int z;
        private int a;
        private Position objPosition;
        public Form1()
        {
            InitializeComponent();
            x = 50;
            y = 50;
        

            objPosition = Position.Right;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.BlueViolet, x, y, 100, 100);
            e.Graphics.DrawImage(new Bitmap("11.gif"), x, y, 100, 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(objPosition==Position.Right)
            {
                x += 10;   
            }
            else if(objPosition==Position.Left)
            {
                x -= 10;  
            }
            else if (objPosition == Position.Up)
            {
                y -= 10;   
            }
            else if (objPosition == Position.Down)
            {
                y += 10;
            }
            else if (objPosition == Position.Stop)
            {
               
            }
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode==Keys.Left)
            {
                objPosition = Position.Left;
            }
           else if (e.KeyCode == Keys.Right)
            {
                objPosition = Position.Right;
            }
            else if (e.KeyCode == Keys.Up)
            {
                objPosition = Position.Up;
            }
            else if (e.KeyCode == Keys.Down)
            {
                objPosition = Position.Down;
            }
            else if (e.KeyCode == Keys.Space)
            {
                objPosition = Position.Stop;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
